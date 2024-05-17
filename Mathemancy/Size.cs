namespace ToolBX.Mathemancy;

public readonly record struct Size<T>(T Width, T Height) : IComparable<Size<T>>, IComparable where T : struct, INumber<T>
{
    public int CompareTo(Size<T> other)
    {
        if (this > other) return 1;
        if (this < other) return -1;
        return 0;
    }

    public int CompareTo(object? obj) => obj is Size<T> size ? CompareTo(size) : 0;

    public static Size<T> operator +(Size<T> a, Size<T> b) => new(a.Width + b.Width, a.Height + b.Height);

    public static Size<T> operator -(Size<T> a, Size<T> b) => new(a.Width - b.Width, a.Height - b.Height);

    public static Size<T> operator +(Size<T> a, T b) => new(a.Width + b, a.Height + b);

    public static Size<T> operator -(Size<T> a, T b) => new(a.Width - b, a.Height - b);

    public static Size<T> operator *(Size<T> a, Size<T> b) => new(a.Width * b.Width, a.Height * b.Height);

    public static Size<T> operator *(Size<T> a, T b) => new(a.Width * b, a.Height * b);

    public static Size<T> operator /(Size<T> a, Size<T> b) => new(a.Width / b.Width, a.Height / b.Height);

    public static Size<T> operator /(Size<T> a, T b) => new(a.Width / b, a.Height / b);

    public static bool operator >(Size<T> a, Size<T> b) => a.Width > b.Width || a.Height > b.Height;
    public static bool operator >=(Size<T> a, Size<T> b) => a > b || a == b;

    public static bool operator <(Size<T> a, Size<T> b) => a.Width < b.Width && a.Height < b.Height;
    public static bool operator <=(Size<T> a, Size<T> b) => a < b || a == b;

    public override string ToString() => $"{Width}x{Height}";

    public static implicit operator Size3D<T>(Size<T> value) => new() { Length = value.Width, Width = value.Height };

    public static Size<T> FromString(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));

        value = value.Trim('(', ')');
        var wh = value.Split('x');

        if (wh.Length != 2)
            throw new InvalidOperationException($"Can't create Size : Expecting 2 values but received {wh.Length}");

        return new Size<T>(wh[0].ParseOrThrow<T>(), wh[1].ParseOrThrow<T>());
    }
}