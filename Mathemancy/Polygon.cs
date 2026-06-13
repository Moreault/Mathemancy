namespace ToolBX.Mathemancy;

/// <summary>
/// Represents a polygon defined by a list of vertices. The vertices are expected to be ordered either clockwise or counterclockwise.
/// </summary>
/// <typeparam name="T">The numeric type of the polygon's vertices.</typeparam>
public readonly struct Polygon<T> : IReadOnlyList<Vector2<T>> where T : struct, INumber<T>
{
    private IReadOnlyList<Vector2<T>> Vertices
    {
        get => _vertices;
        init
        {
            if (value.Count < 3)
                throw new ArgumentException(Exceptions.PolygonRequiresThreeVertices, nameof(Vertices));
            var myVertices = value.ToArray();
            _vertices = myVertices;

            _bounds = new Lazy<Rectangle<T>>(() =>
            {
                var minimumX = myVertices[0].X;
                var minimumY = myVertices[0].Y;
                var maximumX = myVertices[0].X;
                var maximumY = myVertices[0].Y;

                for (int vertexIndex = 1; vertexIndex < myVertices.Length; vertexIndex++)
                {
                    var currentVertex = myVertices[vertexIndex];

                    if (currentVertex.X < minimumX) minimumX = currentVertex.X;
                    if (currentVertex.Y < minimumY) minimumY = currentVertex.Y;
                    if (currentVertex.X > maximumX) maximumX = currentVertex.X;
                    if (currentVertex.Y > maximumY) maximumY = currentVertex.Y;
                }

                return new Rectangle<T>(minimumX, minimumY, maximumX - minimumX, maximumY - minimumY);
            });

            _signedArea = new Lazy<T>(() =>
            {
                var signedArea = T.Zero;
                int vertexCount = myVertices.Length;

                for (int currentIndex = 0, previousIndex = vertexCount - 1;
                     currentIndex < vertexCount;
                     previousIndex = currentIndex++)
                {
                    var currentVertex = myVertices[currentIndex];
                    var previousVertex = myVertices[previousIndex];

                    signedArea += previousVertex.X * currentVertex.Y -
                                  currentVertex.X * previousVertex.Y;
                }

                return signedArea / T.CreateChecked(2);
            });

            _hashcode = new Lazy<int>(() =>
            {
                unchecked
                {
                    return myVertices.Aggregate(17, (current, p) => current * 31 + p.GetHashCode());
                }
            });
        }
    }
    private readonly IReadOnlyList<Vector2<T>> _vertices = null!;

    public int Count => _vertices.Count;

    public Vector2<T> this[int index] => _vertices[index];

    /// <summary>
    /// Rectangular bounds of the polygon.
    /// </summary>
    public Rectangle<T> Bounds => _bounds.Value;
    private readonly Lazy<Rectangle<T>> _bounds = null!;

    private readonly Lazy<int> _hashcode = null!;

    public T SignedArea => _signedArea.Value;
    private readonly Lazy<T> _signedArea = null!;

    public bool IsClockwise => SignedArea < T.Zero;

    public Polygon() : this([])
    {

    }

    public Polygon(IEnumerable<Vector2<T>> vertices)
    {
        Vertices = vertices.ToArray();
    }

    public Polygon(params ReadOnlySpan<Vector2<T>> vertices)
    {
        Vertices = vertices.ToArray();
    }

    public IEnumerator<Vector2<T>> GetEnumerator() => _vertices.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public override int GetHashCode() => _hashcode.Value;

    public override string ToString() => string.Join(" -> ", this);

    public override bool Equals(object? obj) => obj is Polygon<T> other && this.SequenceEqual(other);
}