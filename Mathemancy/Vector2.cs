namespace ToolBX.Mathemancy;

public readonly record struct Vector2<T>(T X, T Y) : IComparable<Vector2<T>> where T : struct, INumber<T>
{
    public static Vector2<T> Zero => default;

    public static bool operator >(Vector2<T> a, Vector2<T> b) => a.X > b.X && a.Y > b.Y;

    public static bool operator <(Vector2<T> a, Vector2<T> b) => a.X < b.X && a.Y < b.Y;

    public static bool operator >=(Vector2<T> a, Vector2<T> b) => a.X >= b.X && a.Y >= b.Y;

    public static bool operator <=(Vector2<T> a, Vector2<T> b) => a.X <= b.X && a.Y <= b.Y;

    public static Vector2<T> operator +(Vector2<T> a, Vector2<T> b) => new(a.X + b.X, a.Y + b.Y);

    public static Vector2<T> operator -(Vector2<T> a, Vector2<T> b) => new(a.X - b.X, a.Y - b.Y);

    public static Vector2<T> operator -(Vector2<T> value) => new(-value.X, -value.Y);

    public static Vector2<T> operator +(Vector2<T> a, T b) => new(a.X + b, a.Y + b);

    public static Vector2<T> operator -(Vector2<T> a, T b) => new(a.X - b, a.Y - b);

    public static Vector2<T> operator *(Vector2<T> a, Vector2<T> b) => new(a.X * b.X, a.Y * b.Y);

    public static Vector2<T> operator /(Vector2<T> a, Vector2<T> b) => new(a.X / b.X, a.Y / b.Y);

    public static Vector2<T> operator *(Vector2<T> a, T b) => new(a.X * b, a.Y * b);

    public static Vector2<T> operator /(Vector2<T> a, T b) => new(a.X / b, a.Y / b);

    public void Deconstruct(out T x, out T y)
    {
        x = X;
        y = Y;
    }

    public override string ToString() => $"({X}, {Y})";

    /// <summary>
    /// Clamps the vector's X and Y values between those of minimum and maximum.
    /// </summary>
    public Vector2<T> Clamp(Vector2<T> minimum, Vector2<T> maximum)
    {
        if (minimum.X.IsGreaterThan(maximum.X) || minimum.Y.IsGreaterThan(maximum.Y))
            throw new ArgumentException(string.Format(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax, minimum, maximum));

        var x = X;
        if (X.IsLesserThan(minimum.X))
            x = minimum.X;
        else if (X.IsGreaterThan(maximum.X))
            x = maximum.X;

        var y = Y;
        if (Y.IsLesserThan(minimum.Y))
            y = minimum.Y;
        else if (Y.IsGreaterThan(maximum.Y))
            y = maximum.Y;

        return new Vector2<T>(x, y);
    }

    public Direction ToDirection()
    {
        if (X == default && Y == default)
            return Direction.None;
        if (X == default && Y < default(T))
            return Direction.Up;
        if (X > default(T) && Y == default)
            return Direction.Right;
        if (X == default && Y > default(T))
            return Direction.Down;
        if (X < default(T) && Y == default)
            return Direction.Left;
        if (X < default(T) && Y < default(T))
            return Direction.UpLeft;
        if (X > default(T) && Y < default(T))
            return Direction.UpRight;
        if (X < default(T) && Y > default(T))
            return Direction.DownLeft;
        if (X > default(T) && Y > default(T))
            return Direction.DownRight;

        throw new NotSupportedException();
    }

    public static implicit operator Vector2<T>(Vector3<T> value) => new(value.X, value.Y);

    public Vector3<T> ToVector3() => new(X, Y, default);

    public static Vector2<T> FromString(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
        var xy = value.Trim('(', ')').Split(',');
        if (xy.Length != 2) throw new Exception($"Can't create Vector2 : Expecting 2 values but received {xy.Length}");
        return Vector3<T>.FromString(value);
    }

    public int CompareTo(Vector2<T> other)
    {
        if (this > other) return 1;
        if (this < other) return -1;
        return 0;
    }
}