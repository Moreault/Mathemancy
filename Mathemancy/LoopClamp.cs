namespace ToolBX.Mathemancy;

public static class LoopClampExtensions
{
    /// <summary>
    /// Clamps between min and max values and then loops around using the remaining overflow.
    /// </summary>
    public static T LoopClamp<T>(this T value, T min, T max) where T : INumber<T>
    {
        if (min.IsGreaterThanOrEqualTo(max)) throw new ArgumentException(string.Format(Exceptions.MaximumValueMustBeGreaterThanMinimum, max, min));

        while (value.IsGreaterThan(max))
            value -= max;
        while (value.IsLesserThan(min))
            value = max - (min - value);
        return value;
    }
}