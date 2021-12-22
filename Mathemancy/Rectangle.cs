using ToolBX.Mathemancy.Expressions;

namespace ToolBX.Mathemancy;

public readonly record struct Rectangle<T> : IComparable<Rectangle<T>>, IComparable where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public static readonly Rectangle<T> Empty = new();

    public Vector2<T> Position { get; init; }

    public Size<T> Size { get; init; }

    public T X => Position.X;

    public T Y => Position.Y;

    public T Width => Size.Width;

    public T Height => Size.Height;

    public T Left => X;

    public T Right => Operator<T>.Add(X, Width);

    public T Top => Y;

    public T Bottom => Operator<T>.Add(Y, Height);

    public Vector2<T> TopLeft => Position;

    public Vector2<T> TopRight => new(Right, Y);

    public Vector2<T> BottomLeft => new(Left, Bottom);

    public Vector2<T> BottomRight => new(Right, Bottom);

    public Rectangle(T x, T y, T width, T height) : this(new Vector2<T>(x, y), new Size<T>(width, height))
    {
    }

    public Rectangle(Vector2<T> position, Size<T> size)
    {
        Position = position;
        Size = size;
    }

    public Rectangle(Vector2<T> position, T width, T height) : this(position, new Size<T>(width, height))
    {

    }

    public Rectangle(T x, T y, Size<T> size) : this(new Vector2<T>(x, y), size)
    {

    }

    public int CompareTo(Rectangle<T> other)
    {
        if (Size > other.Size) return 1;
        if (Size < other.Size) return -1;
        return 0;
    }

    public int CompareTo(object? obj) => obj is Rectangle<T> rectangle ? CompareTo(rectangle) : 0;

    public override int GetHashCode() => HashCode.Combine(X, Y, Width, Height);

    public bool Equals(Rectangle<T> other) => X.Equals(other.X) && Y.Equals(other.Y) && Width.Equals(other.Width) && Height.Equals(other.Height);

    public static bool operator >(Rectangle<T> a, Rectangle<T> b) => a.Size > b.Size;
    public static bool operator >=(Rectangle<T> a, Rectangle<T> b) => a.Size >= b.Size;

    public static bool operator <(Rectangle<T> a, Rectangle<T> b) => a.Size < b.Size;
    public static bool operator <=(Rectangle<T> a, Rectangle<T> b) => a.Size <= b.Size;

    public static bool operator >(Rectangle<T> a, Size<T> b) => a.Size > b;
    public static bool operator >=(Rectangle<T> a, Size<T> b) => a.Size >= b;

    public static bool operator <(Rectangle<T> a, Size<T> b) => a.Size < b;
    public static bool operator <=(Rectangle<T> a, Size<T> b) => a.Size <= b;

    public override string ToString() => $"X: {X}, Y: {Y}, Width: {Width}, Height: {Height}";
}