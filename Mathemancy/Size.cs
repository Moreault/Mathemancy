using ToolBX.Mathemancy.Expressions;

namespace ToolBX.Mathemancy;

public readonly record struct Size<T>(T Width, T Height) : IComparable<Size<T>>, IComparable where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public int CompareTo(Size<T> other)
    {
        if (this > other) return 1;
        if (this < other) return -1;
        return 0;
    }

    public int CompareTo(object? obj) => obj is Size<T> size ? CompareTo(size) : 0;

    public static Size<T> operator +(Size<T> a, Size<T> b) => new(Operator<T>.Add(a.Width, b.Width), Operator<T>.Add(a.Height, b.Height));

    public static Size<T> operator -(Size<T> a, Size<T> b) => new(Operator<T>.Subtract(a.Width, b.Width), Operator<T>.Subtract(a.Height, b.Height));

    public static Size<T> operator +(Size<T> a, T b) => new(Operator<T>.Add(a.Width, b), Operator<T>.Add(a.Height, b));

    public static Size<T> operator -(Size<T> a, T b) => new(Operator<T>.Subtract(a.Width, b), Operator<T>.Subtract(a.Height, b));

    public static Size<T> operator *(Size<T> a, Size<T> b) => new(Operator<T>.Multiply(a.Width, b.Width), Operator<T>.Multiply(a.Height, b.Height));

    public static Size<T> operator *(Size<T> a, T b) => new(Operator<T>.Multiply(a.Width, b), Operator<T>.Multiply(a.Height, b));

    public static Size<T> operator /(Size<T> a, Size<T> b) => new(Operator<T>.Divide(a.Width, b.Width), Operator<T>.Divide(a.Height, b.Height));

    public static Size<T> operator /(Size<T> a, T b) => new(Operator<T>.Divide(a.Width, b), Operator<T>.Divide(a.Height, b));

    public static bool operator >(Size<T> a, Size<T> b) => Operator<T>.GreaterThan(a.Width, b.Width) || Operator<T>.GreaterThan(a.Height, b.Height);
    public static bool operator >=(Size<T> a, Size<T> b) => a > b || a == b;

    public static bool operator <(Size<T> a, Size<T> b) => Operator<T>.LessThan(a.Width, b.Width) && Operator<T>.LessThan(a.Height, b.Height);
    public static bool operator <=(Size<T> a, Size<T> b) => a < b || a == b;

    public override string ToString() => $"{Width}x{Height}";
}