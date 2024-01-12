namespace ToolBX.Mathemancy;

/// <summary>
/// Two-dimensional planar figure with four straight sides and four right angles.
/// </summary>
public readonly record struct Rectangle<T>(Vector2<T> Position, Size<T> Size) : IComparable<Rectangle<T>>, IComparable where T : struct, INumber<T>
{
    public static readonly Rectangle<T> Empty = new();

    [JsonIgnore]
    public T X => Position.X;

    [JsonIgnore]
    public T Y => Position.Y;

    [JsonIgnore]
    public T Width => Size.Width;

    [JsonIgnore]
    public T Height => Size.Height;

    [JsonIgnore]
    public T Left => X;

    [JsonIgnore]
    public T Right => X + Width;

    [JsonIgnore]
    public T Top => Y;

    [JsonIgnore]
    public T Bottom => Y + Height;

    [JsonIgnore]
    public Vector2<T> TopLeft => Position;

    [JsonIgnore]
    public Vector2<T> TopRight => new(Right, Y);

    [JsonIgnore]
    public Vector2<T> BottomLeft => new(Left, Bottom);

    [JsonIgnore]
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
        else if (point1.X <= point2.X)
            topLeft = point1.Y <= point2.Y ? point1 : new Vector2<T>(point1.X, point2.Y);
        else
            topLeft = point1.Y <= point2.Y ? new Vector2<T>(point2.X, point1.Y) : point2;
        
        return new Rectangle<T>(topLeft, T.Abs(point1.X - point2.X), T.Abs(point1.Y - point2.Y));
    }
}