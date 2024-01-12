namespace ToolBX.Mathemancy.Randomness;

/// <summary>
/// Generates cryptographically-secure random numbers. It is less predictable than <see cref="IPseudoRandomNumberGenerator"/> but also much slower.
/// </summary>
public interface ISecureRandomNumberGenerator : IRandomNumberGenerator, IDisposable
{

}

[AutoInject(ServiceLifetime.Singleton)]
public class SecureRandomNumberGenerator : ISecureRandomNumberGenerator
{
    private readonly RandomNumberGenerator _randomNumberGenerator = RandomNumberGenerator.Create();

    public T Generate<T>() where T : INumber<T>, IMinMaxValue<T> => Generate(T.MinValue, T.MaxValue);

    public T Generate<T>(T max) where T : INumber<T> => Generate(T.Zero, max);

    public T Generate<T>(T min, T max) where T : INumber<T>
    {
        if (min is int or short)
            return T.CreateChecked(RandomNumberGenerator.GetInt32(int.CreateChecked(min), int.CreateChecked(max)));

        var bytes = RandomNumberGenerator.GetBytes(sizeof(long));
        _randomNumberGenerator.GetNonZeroBytes(bytes);
        var random = BitConverter.ToInt64(bytes);

        var min64 = long.CreateSaturating(min);
        var max64 = long.CreateSaturating(max);

        return T.CreateChecked(((random - min64) % long.Clamp(max64 - min64 + 1, 1, long.MaxValue) + (max64 - min64) + 1) % long.Clamp(max64 - min64 + 1, 1, long.MaxValue) + min64);
    }

    public double GenerateFractions() => GenerateFractions<double>();

    public T GenerateFractions<T>() where T : IFloatingPoint<T>
    {
        var digits = Generate(int.MaxValue);
        var number = digits.ToString().Length;

        var zeroes = 1d;
        for (var i = 0; i < number; i++)
            zeroes *= 10;

        return T.CreateChecked(digits / zeroes);
    }

    public void Dispose() => _randomNumberGenerator.Dispose();
}