using System.Numerics;
using ToolBX.Mathemancy.Resources;

namespace ToolBX.Mathemancy;

public readonly record struct Vector2<T>(T X, T Y) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public static Vector2<T> Zero => default;

    public static bool operator >(Vector2<T> a, Vector2<T> b) => a.X.IsGreaterThan(b.X) && a.Y.IsGreaterThan(b.Y);

    public static bool operator <(Vector2<T> a, Vector2<T> b) => a.X.IsLesserThan(b.X) && a.Y.IsLesserThan(b.Y);

    public static bool operator >=(Vector2<T> a, Vector2<T> b) => a.X.IsGreaterThanOrEqualTo(b.X) && a.Y.IsGreaterThanOrEqualTo(b.Y);

    public static bool operator <=(Vector2<T> a, Vector2<T> b) => a.X.IsLesserThanOrEqualTo(b.X) && a.Y.IsLesserThanOrEqualTo(b.Y);

    public static Vector2<T> operator +(Vector2<T> a, Vector2<T> b) => new(Operator<T>.Add(a.X, b.X), Operator<T>.Add(a.Y, b.Y));

    public static Vector2<T> operator -(Vector2<T> a, Vector2<T> b) => new(Operator<T>.Subtract(a.X, b.X), Operator<T>.Subtract(a.Y, b.Y));

    public static Vector2<T> operator -(Vector2<T> value) => new(Operator<T>.Negate(value.X), Operator<T>.Negate(value.Y));

    public static Vector2<T> operator +(Vector2<T> a, T b) => new(Operator<T>.Add(a.X, b), Operator<T>.Add(a.Y, b));

    public static Vector2<T> operator -(Vector2<T> a, T b) => new(Operator<T>.Subtract(a.X, b), Operator<T>.Subtract(a.Y, b));

    public static Vector2<T> operator *(Vector2<T> a, Vector2<T> b) => new(Operator<T>.Multiply(a.X, b.X), Operator<T>.Multiply(a.Y, b.Y));

    public static Vector2<T> operator /(Vector2<T> a, Vector2<T> b) => new(Operator<T>.Divide(a.X, b.X), Operator<T>.Divide(a.Y, b.Y));

    public static Vector2<T> operator *(Vector2<T> a, T b) => new(Operator<T>.Multiply(a.X, b), Operator<T>.Multiply(a.Y, b));

    public static Vector2<T> operator /(Vector2<T> a, T b) => new(Operator<T>.Divide(a.X, b), Operator<T>.Divide(a.Y, b));

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

    public static implicit operator Vector2<T>(Vector3<T> value) => new(value.X, value.Y);

    public Vector3<T> ToVector3() => new(X, Y, default);

    public static Vector2<T> FromString(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
        var xy = value.Trim('(', ')').Split(',');
        if (xy.Length != 2) throw new Exception($"Can't create Vector2 : Expecting 2 values but received {xy.Length}");
        return Vector3<T>.FromString(value);
    }
}