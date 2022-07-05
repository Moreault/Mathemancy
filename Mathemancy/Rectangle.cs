namespace ToolBX.Mathemancy;

/// <summary>
/// Two-dimensional planar figure with four straight sides and four right angles.
/// </summary>
public readonly record struct Rectangle<T>(Vector2<T> Position, Size<T> Size) : IComparable<Rectangle<T>>, IComparable where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public static readonly Rectangle<T> Empty = new();

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

    public static bool operator >(Rectangle<T> a, Rectangle<T> b) => a.Size > b.Size;
    public static bool operator >=(Rectangle<T> a, Rectangle<T> b) => a.Size >= b.Size;

    public static bool operator <(Rectangle<T> a, Rectangle<T> b) => a.Size < b.Size;
    public static bool operator <=(Rectangle<T> a, Rectangle<T> b) => a.Size <= b.Size;

    public static bool operator >(Rectangle<T> a, Size<T> b) => a.Size > b;
    public static bool operator >=(Rectangle<T> a, Size<T> b) => a.Size >= b;

    public static bool operator <(Rectangle<T> a, Size<T> b) => a.Size < b;
    public static bool operator <=(Rectangle<T> a, Size<T> b) => a.Size <= b;

    public override string ToString() => $"X: {X}, Y: {Y}, Width: {Width}, Height: {Height}";

    public static Rectangle<T> FromCoordinates(Vector2<T> point1, Vector2<T> point2)
    {
        Vector2<T> topLeft;

        if (point1 == point2)
            topLeft = point1;
        else if (Operator<T>.LessThanOrEqual(point1.X, point2.X))
            topLeft = Operator<T>.LessThanOrEqual(point1.Y, point2.Y) ? point1 : new Vector2<T>(point1.X, point2.Y);
        else
            topLeft = Operator<T>.LessThanOrEqual(point1.Y, point2.Y) ? new Vector2<T>(point2.X, point1.Y) : point2;

        return new Rectangle<T>(topLeft, new Size<T>(Operator<T>.Absolute(Operator<T>.Subtract(point1.X, point2.X)), Operator<T>.Absolute(Operator<T>.Subtract(point1.Y, point2.Y))));
    }
}