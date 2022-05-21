namespace ToolBX.Mathemancy.Randomness;

/// <summary>
/// Generates pseudo random numbers. It is more performant than <see cref="ISecureRandomNumberGenerator"/> but is also much more predictable.
/// </summary>
public interface IPseudoRandomNumberGenerator : IRandomNumberGenerator
{
 
}

[AutoInject]
public class PseudoRandomNumberGenerator : IPseudoRandomNumberGenerator
{
    private readonly Random _random = new();

    public int Generate(int max) => Generate(0, max);

    public int Generate(int min, int max) => _random.Next(min, max == int.MaxValue ? int.MaxValue : max + 1);

    public long Generate(long max) => Generate(0, max);

    public long Generate(long min, long max) => _random.NextInt64(min, max == long.MaxValue ? long.MaxValue : max + 1);

    public double Generate(double max) => Generate(0, max);

    public double Generate(double min, double max) => _random.NextInt64((long)min, (long)max) + GenerateFractions();

    public double GenerateFractions() => _random.NextDouble();
}