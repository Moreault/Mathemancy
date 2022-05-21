namespace ToolBX.Mathemancy.Randomness;

public interface IRandomNumberGenerator
{
    /// <summary>
    /// Generates a random integer between zero and max inclusively.
    /// </summary>
    int Generate(int max);

    /// <summary>
    /// Generates a random integer between min and max inclusively.
    /// </summary>
    int Generate(int min, int max);

    /// <summary>
    /// Generates a random long between zero and max inclusively.
    /// </summary>
    long Generate(long max);

    /// <summary>
    /// Generates a random long between min and max inclusively.
    /// </summary>
    long Generate(long min, long max);

    /// <summary>
    /// Generates a random double between zero and max inclusively.
    /// </summary>
    double Generate(double max);

    /// <summary>
    /// Generates a random double between min and max inclusively.
    /// </summary>
    double Generate(double min, double max);

    /// <summary>
    /// Generates a random double greater than 0.0 and lower than 1.0.
    /// </summary>
    double GenerateFractions();
}