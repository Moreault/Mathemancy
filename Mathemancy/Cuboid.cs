namespace ToolBX.Mathemancy;

/// <summary>
/// Three-dimensional rectangular figure.
/// </summary>
public readonly record struct Cuboid<T>(Vector3<T> Position, Size3D<T> Size) : IComparable<Cuboid<T>>, IComparable where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public static readonly Cuboid<T> Empty = new();

    public T X => Position.X;

    public T Y => Position.Y;

    public T Z => Position.Z;

    public T Length => Size.Length;

    public T Width => Size.Width;

    public T Height => Size.Height;

    public Rectangle<T> Front { get; } = new(Position.X, Position.Y, Size.Length, Size.Height);
    public Rectangle<T> Top => throw new NotImplementedException();
    public Rectangle<T> Right => throw new NotImplementedException();
    public Rectangle<T> Bottom => throw new NotImplementedException();
    public Rectangle<T> Left => throw new NotImplementedException();
    public Rectangle<T> Back => throw new NotImplementedException();

    public IReadOnlyList<Vector3<T>> Vertices => _vertices.Value;
    //TODO Calculate vertices
    private readonly Lazy<IReadOnlyList<Vector3<T>>> _vertices = new Lazy<IReadOnlyList<Vector3<T>>>();

    public int CompareTo(Cuboid<T> other)
    {
        if (Size > other.Size) return 1;
        if (Size < other.Size) return -1;
        return 0;
    }

    public int CompareTo(object? obj) => obj is Cuboid<T> rectangle ? CompareTo(rectangle) : 0;

    public override string ToString() => $"X: {X}, Y: {Y}, Z: {Z}, Length: {Length}, Width: {Width}, Height: {Height}";

}