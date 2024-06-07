namespace ToolBX.Mathemancy.Randomness;

/// <summary>
/// Generates pseudo random numbers. It is more performant than <see cref="ISecureRandomNumberGenerator"/> but is also much more predictable.
/// </summary>
public interface IPseudoRandomNumberGenerator : IRandomNumberGenerator;

[AutoInject(ServiceLifetime.Singleton)]
public class PseudoRandomNumberGenerator : IPseudoRandomNumberGenerator
{
    /// <summary>
    /// Provides a thread-safe <see cref="PseudoRandomNumberGenerator"/> instance that may be used concurrently from any thread.
    /// </summary>
    public static PseudoRandomNumberGenerator Shared { get; } = new()
    {
        Random = Random.Shared
    };

    private Random Random { get; set; } = new();

    public int Seed
    {
        set => Random = new Random(value);
    }

    public T Generate<T>() where T : INumber<T>, IMinMaxValue<T> => Generate(T.MinValue, T.MaxValue);

    public T Generate<T>(T max) where T : INumber<T> => Generate(T.Zero, max);

    public T Generate<T>(T min, T max) where T : INumber<T>
    {
        if (min is int or short or byte or sbyte or ushort)
            return T.CreateChecked(Random.Next(int.CreateChecked(min), int.CreateChecked(max)));

        var main = T.CreateChecked(Random.NextInt64(long.CreateSaturating(min), long.CreateSaturating(max)));

        if (min is float or double or decimal)
            return T.Clamp(T.CreateTruncating(Random.NextDouble()) + main, min, max);

        return main;
    }

    public double GenerateFractions() => GenerateFractions<double>();

    public T GenerateFractions<T>() where T : IFloatingPoint<T> => T.CreateTruncating(Random.NextDouble());
}