using System.Numerics;

namespace ToolBX.Mathemancy;

public readonly record struct Size3D<T>(T Length, T Width, T Height) : IComparable<Size3D<T>>, IComparable where T : struct, INumber<T>
{
    public int CompareTo(Size3D<T> other)
    {
        if (this > other) return 1;
        if (this < other) return -1;
        return 0;
    }

    public int CompareTo(object? obj) => obj is Size3D<T> size ? CompareTo(size) : 0;

    public static Size3D<T> operator +(Size3D<T> a, Size3D<T> b) => new(a.Length + b.Length, a.Width + b.Width, a.Height + b.Height);

    public static Size3D<T> operator -(Size3D<T> a, Size3D<T> b) => new(a.Length - b.Length, a.Width - b.Width, a.Height - b.Height);

    public static Size3D<T> operator +(Size3D<T> a, T b) => new(a.Length + b, a.Width + b, a.Height + b);

    public static Size3D<T> operator -(Size3D<T> a, T b) => new(a.Length - b, a.Width - b, a.Height - b);

    public static Size3D<T> operator *(Size3D<T> a, Size3D<T> b) => new(a.Length * b.Length, a.Width * b.Width, a.Height * b.Height);

    public static Size3D<T> operator *(Size3D<T> a, T b) => new(a.Length * b, a.Width * b, a.Height * b);

    public static Size3D<T> operator /(Size3D<T> a, Size3D<T> b) => new(a.Length / b.Length, a.Width / b.Width, a.Height / b.Height);

    public static Size3D<T> operator /(Size3D<T> a, T b) => new(a.Length / b, a.Width / b, a.Height / b);

    public static bool operator >(Size3D<T> a, Size3D<T> b) => a.Length > b.Length || a.Width > b.Width || a.Height > b.Height;
    public static bool operator >=(Size3D<T> a, Size3D<T> b) => a > b || a == b;

    public static bool operator <(Size3D<T> a, Size3D<T> b) => a.Length < b.Length && a.Width < b.Width && a.Height < b.Height;
    public static bool operator <=(Size3D<T> a, Size3D<T> b) => a < b || a == b;

    public override string ToString() => $"{Length}x{Width}x{Height}";

    public static implicit operator Size<T>(Size3D<T> value) => new(value.Length, value.Width);

    public static Size3D<T> FromString(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));

        value = value.Trim('(', ')');
        var lwh = value.Split('x');

        if (lwh.Length != 3)
            throw new Exception($"Can't create Size : Expecting 3 values but received {lwh.Length}");

        return new Size3D<T>(lwh[0].ParseOrThrow<T>(), lwh[1].ParseOrThrow<T>(), lwh[2].ParseOrThrow<T>());
    }
}