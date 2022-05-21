namespace ToolBX.Mathemancy;

public readonly record struct Size3D<T>(T Length, T Width, T Height) : IComparable<Size3D<T>>, IComparable where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public int CompareTo(Size3D<T> other)
    {
        if (this > other) return 1;
        if (this < other) return -1;
        return 0;
    }

    public int CompareTo(object? obj) => obj is Size3D<T> size ? CompareTo(size) : 0;

    public static Size3D<T> operator +(Size3D<T> a, Size3D<T> b) => new(Operator<T>.Add(a.Length, b.Length), Operator<T>.Add(a.Width, b.Width), Operator<T>.Add(a.Height, b.Height));

    public static Size3D<T> operator -(Size3D<T> a, Size3D<T> b) => new(Operator<T>.Subtract(a.Length, b.Length), Operator<T>.Subtract(a.Width, b.Width), Operator<T>.Subtract(a.Height, b.Height));

    public static Size3D<T> operator +(Size3D<T> a, T b) => new(Operator<T>.Add(a.Length, b), Operator<T>.Add(a.Width, b), Operator<T>.Add(a.Height, b));

    public static Size3D<T> operator -(Size3D<T> a, T b) => new(Operator<T>.Subtract(a.Length, b), Operator<T>.Subtract(a.Width, b), Operator<T>.Subtract(a.Height, b));

    public static Size3D<T> operator *(Size3D<T> a, Size3D<T> b) => new(Operator<T>.Multiply(a.Length, b.Length), Operator<T>.Multiply(a.Width, b.Width), Operator<T>.Multiply(a.Height, b.Height));

    public static Size3D<T> operator *(Size3D<T> a, T b) => new(Operator<T>.Multiply(a.Length, b), Operator<T>.Multiply(a.Width, b), Operator<T>.Multiply(a.Height, b));

    public static Size3D<T> operator /(Size3D<T> a, Size3D<T> b) => new(Operator<T>.Divide(a.Length, b.Length), Operator<T>.Divide(a.Width, b.Width), Operator<T>.Divide(a.Height, b.Height));

    public static Size3D<T> operator /(Size3D<T> a, T b) => new(Operator<T>.Divide(a.Length, b), Operator<T>.Divide(a.Width, b), Operator<T>.Divide(a.Height, b));

    public static bool operator >(Size3D<T> a, Size3D<T> b) => Operator<T>.GreaterThan(a.Length, b.Length) || Operator<T>.GreaterThan(a.Width, b.Width) || Operator<T>.GreaterThan(a.Height, b.Height);
    public static bool operator >=(Size3D<T> a, Size3D<T> b) => a > b || a == b;

    public static bool operator <(Size3D<T> a, Size3D<T> b) => Operator<T>.LessThan(a.Length, b.Length) && Operator<T>.LessThan(a.Width, b.Width) && Operator<T>.LessThan(a.Height, b.Height);
    public static bool operator <=(Size3D<T> a, Size3D<T> b) => a < b || a == b;

    public override string ToString() => $"{Length}x{Width}x{Height}";

    public static implicit operator Size<T>(Size3D<T> value) => new(value.Length, value.Width);
}