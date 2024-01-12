namespace ToolBX.Mathemancy.Randomness;

public interface IRandomNumberGenerator
{
    /// <summary>
    /// Generates a random number between <see cref="IMinMaxValue{TSelf}.MinValue"/> and <see cref="IMinMaxValue{TSelf}.MaxValue"/>.
    /// </summary>
    T Generate<T>() where T : INumber<T>, IMinMaxValue<T>;

    /// <summary>
    /// Generates a random number between zero and max inclusively.
    /// </summary>
    T Generate<T>(T max) where T : INumber<T>;

    /// <summary>
    /// Generates a random number between min and max inclusively.
    /// </summary>
    T Generate<T>(T min, T max) where T : INumber<T>;

    double GenerateFractions();

    /// <summary>
    /// Generates a random double greater than 0.0 and lower than 1.0.
    /// </summary>
    T GenerateFractions<T>() where T : IFloatingPoint<T>;
}