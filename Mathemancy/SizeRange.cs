namespace ToolBX.Mathemancy;

public readonly record struct SizeRange<T> : IComparable<SizeRange<T>>, IComparable, IEquatable<Size<T>> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public Size<T> Minimum { get; init; }
    public Size<T> Maximum { get; init; }

    public SizeRange(Size<T> size) : this(size, size)
    {

    }

    public SizeRange(T width, T height) : this(new Size<T>(width, height), new Size<T>(width, height))
    {

    }

    public SizeRange(T minimumWidth, T minimumHeight, T maximumWidth, T maximumHeight) : this(new Size<T>(minimumWidth, minimumHeight), new Size<T>(maximumWidth, maximumHeight))
    {

    }

    public SizeRange(Size<T> minimum, Size<T> maximum)
    {
        if (Operator<T>.LessThan(maximum.Width, minimum.Width) || Operator<T>.LessThan(maximum.Height, minimum.Height)) throw new ArgumentException($"Can't create {nameof(SizeRange<T>)} : {nameof(maximum)} should be greater than or equal to {nameof(minimum)} but their values are {minimum} and {maximum} respectively.");
        Minimum = minimum;
        Maximum = maximum;
    }

    public bool Equals(Size<T> size) => Contains(size);

    public static bool operator <(SizeRange<T> a, SizeRange<T> b) => a.Minimum < b.Minimum || a.Maximum < b.Maximum;
    public static bool operator <=(SizeRange<T> a, SizeRange<T> b) => a < b || a == b;

    public static bool operator >(SizeRange<T> a, SizeRange<T> b) => a.Minimum > b.Minimum || a.Maximum > b.Maximum;
    public static bool operator >=(SizeRange<T> a, SizeRange<T> b) => a > b || a == b;

    public static bool operator ==(SizeRange<T> a, Size<T> b) => a.Equals(b);
    public static bool operator !=(SizeRange<T> a, Size<T> b) => !(a == b);

    public static bool operator >(Size<T> a, SizeRange<T> b) => a > b.Maximum;
    public static bool operator <(Size<T> a, SizeRange<T> b) => a < b.Minimum;

    public static bool operator >=(Size<T> a, SizeRange<T> b) => a >= b.Maximum;
    public static bool operator <=(Size<T> a, SizeRange<T> b) => a <= b.Minimum;

    public bool Contains(Size<T> size) => size >= Minimum && size <= Maximum;

    public int CompareTo(SizeRange<T> other)
    {
        if (this > other) return 1;
        if (this < other) return -1;
        return 0;
    }

    public int CompareTo(object? obj) => obj is SizeRange<T> other ? CompareTo(other) : 0;

    public override string ToString() => $"Between {Minimum} and {Maximum}";
}