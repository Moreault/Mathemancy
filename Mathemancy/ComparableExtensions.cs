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
}