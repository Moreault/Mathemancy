namespace ToolBX.Mathemancy;

public static class ComparableExtensions
{
    public static bool IsGreaterThan<T>(this T actual, T comp) where T : IComparable<T>
    {
        return actual.CompareTo(comp) > 0;
    }

    public static bool IsGreaterThanOrEqualTo<T>(this T actual, T comp) where T : IComparable<T>
    {
        return actual.CompareTo(comp) >= 0;
    }

    public static bool IsLesserThan<T>(this T actual, T comp) where T : IComparable<T>
    {
        return actual.CompareTo(comp) < 0;
    }

    public static bool IsLesserThanOrEqualTo<T>(this T actual, T comp) where T : IComparable<T>
    {
        return actual.CompareTo(comp) <= 0;
    }

    public static bool IsGreaterThan<T>(this T actual, object comp) where T : IComparable
    {
        return actual.CompareTo(comp) > 0;
    }

    public static bool IsGreaterThanOrEqualTo<T>(this T actual, object comp) where T : IComparable
    {
        return actual.CompareTo(comp) >= 0;
    }

    public static bool IsLesserThan<T>(this T actual, object comp) where T : IComparable
    {
        return actual.CompareTo(comp) < 0;
    }

    public static bool IsLesserThanOrEqualTo<T>(this T actual, object comp) where T : IComparable
    {
        return actual.CompareTo(comp) <= 0;
    }

    public static T Clamp<T>(this T value, T min, T max, Comparer<T>? comparer = null) where T : IComparable<T>
    {
        comparer ??= Comparer<T>.Default;
        if (min.IsGreaterThan(max)) throw new ArgumentException(string.Format(Exceptions.MaximumValueMustBeGreaterThanMinimum, max, min));

        if (value.IsLesserThan(min)) return min;
        if (value.IsGreaterThan(max)) return max;
        return value;
    }
}