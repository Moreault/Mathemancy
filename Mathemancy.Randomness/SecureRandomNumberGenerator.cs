namespace ToolBX.Mathemancy.Randomness;

/// <summary>
/// Generates cryptographically-secure random numbers. It is less predictable than <see cref="IPseudoRandomNumberGenerator"/> but also much slower.
/// </summary>
public interface ISecureRandomNumberGenerator : IRandomNumberGenerator, IDisposable
{

}

[AutoInject]
public class SecureRandomNumberGenerator : ISecureRandomNumberGenerator
{
    private readonly RandomNumberGenerator _randomNumberGenerator;

    public SecureRandomNumberGenerator()
    {
        _randomNumberGenerator = RandomNumberGenerator.Create();
    }

    public int Generate(int max) => Generate(0, max);

    public int Generate(int min, int max) => RandomNumberGenerator.GetInt32(min, max == int.MaxValue ? int.MaxValue : max + 1);

    public long Generate(long max) => Generate(0, max);

    public long Generate(long min, long max)
    {
        var bytes = RandomNumberGenerator.GetBytes(sizeof(long));
        _randomNumberGenerator.GetNonZeroBytes(bytes);
        var random = BitConverter.ToInt64(bytes);
        return ((random - min) % (max - min + 1) + (max - min) + 1) % (max - min + 1) + min;
    }

    public double Generate(double max) => Generate(0, max);

    public double Generate(double min, double max)
    {
        var bytes = RandomNumberGenerator.GetBytes(sizeof(double));
        _randomNumberGenerator.GetNonZeroBytes(bytes);
        var random = BitConverter.ToDouble(bytes);
        return ((random - min) % (max - min + 1) + (max - min) + 1) % (max - min + 1) + min;
    }

    public double GenerateFractions()
    {
        var digits = Generate(int.MaxValue);
        var number = digits.ToString().Length;

        var zeroes = 1d;
        for (var i = 0; i < number; i++)
            zeroes *= 10;

        return digits / zeroes;
    }

    public void Dispose() => _randomNumberGenerator.Dispose();
}