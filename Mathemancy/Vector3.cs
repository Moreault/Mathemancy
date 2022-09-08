using ToolBX.EasyTypeParsing;
using ToolBX.Mathemancy.Resources;

namespace ToolBX.Mathemancy;

public readonly record struct Vector3<T>(T X, T Y, T Z) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public static Vector3<T> Zero => default;

    public static Vector3<T> Forward => new(default, default, (T)(object)-1.0f);

    public Vector3(T x, T y) : this(x, y, default)
    {

    }

    public bool Equals(Vector3<T> other) => X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
    public override int GetHashCode() => HashCode.Combine(X, Y, Z);

    public static bool operator >(Vector3<T> a, Vector3<T> b) => a.X.IsGreaterThan(b.X) && a.Y.IsGreaterThan(b.Y) && a.Z.IsGreaterThan(b.Z);

    public static bool operator <(Vector3<T> a, Vector3<T> b) => a.X.IsLesserThan(b.X) && a.Y.IsLesserThan(b.Y) && a.Z.IsLesserThan(b.Z);

    public static bool operator >=(Vector3<T> a, Vector3<T> b) => a.X.IsGreaterThanOrEqualTo(b.X) && a.Y.IsGreaterThanOrEqualTo(b.Y) && a.Z.IsGreaterThanOrEqualTo(b.Z);

    public static bool operator <=(Vector3<T> a, Vector3<T> b) => a.X.IsLesserThanOrEqualTo(b.X) && a.Y.IsLesserThanOrEqualTo(b.Y) && a.Z.IsLesserThanOrEqualTo(b.Z);

    public static Vector3<T> operator +(Vector3<T> a, Vector3<T> b) => new(Operator<T>.Add(a.X, b.X), Operator<T>.Add(a.Y, b.Y), Operator<T>.Add(a.Z, b.Z));

    public static Vector3<T> operator -(Vector3<T> a, Vector3<T> b) => new(Operator<T>.Subtract(a.X, b.X), Operator<T>.Subtract(a.Y, b.Y), Operator<T>.Subtract(a.Z, b.Z));

    public static Vector3<T> operator -(Vector3<T> value) => new(Operator<T>.Negate(value.X), Operator<T>.Negate(value.Y), Operator<T>.Negate(value.Z));

    public static Vector3<T> operator +(Vector3<T> a, T b) => new(Operator<T>.Add(a.X, b), Operator<T>.Add(a.Y, b), Operator<T>.Add(a.Z, b));

    public static Vector3<T> operator -(Vector3<T> a, T b) => new(Operator<T>.Subtract(a.X, b), Operator<T>.Subtract(a.Y, b), Operator<T>.Subtract(a.Z, b));

    public static Vector3<T> operator *(Vector3<T> a, Vector3<T> b) => new(Operator<T>.Multiply(a.X, b.X), Operator<T>.Multiply(a.Y, b.Y), Operator<T>.Multiply(a.Z, b.Z));

    public static Vector3<T> operator /(Vector3<T> a, Vector3<T> b) => new(Operator<T>.Divide(a.X, b.X), Operator<T>.Divide(a.Y, b.Y), Operator<T>.Divide(a.Z, b.Z));

    public static Vector3<T> operator *(Vector3<T> a, T b) => new(Operator<T>.Multiply(a.X, b), Operator<T>.Multiply(a.Y, b), Operator<T>.Multiply(a.Z, b));

    public static Vector3<T> operator /(Vector3<T> a, T b) => new(Operator<T>.Divide(a.X, b), Operator<T>.Divide(a.Y, b), Operator<T>.Divide(a.Z, b));

    public static bool operator >(Vector3<T> a, Vector2<T> b) => a.X.IsGreaterThan(b.X) && a.Y.IsGreaterThan(b.Y) && a.Z.IsGreaterThan(default);

    public static bool operator <(Vector3<T> a, Vector2<T> b) => a.X.IsLesserThan(b.X) && a.Y.IsLesserThan(b.Y) && a.Z.IsLesserThan(default);

    public static bool operator >=(Vector3<T> a, Vector2<T> b) => a.X.IsGreaterThanOrEqualTo(b.X) && a.Y.IsGreaterThanOrEqualTo(b.Y) && a.Z.IsGreaterThanOrEqualTo(default);

    public static bool operator <=(Vector3<T> a, Vector2<T> b) => a.X.IsLesserThanOrEqualTo(b.X) && a.Y.IsLesserThanOrEqualTo(b.Y) && a.Z.IsLesserThanOrEqualTo(default);

    public static Vector3<T> operator +(Vector3<T> a, Vector2<T> b) => new(Operator<T>.Add(a.X, b.X), Operator<T>.Add(a.Y, b.Y), a.Z);

    public static Vector3<T> operator -(Vector3<T> a, Vector2<T> b) => new(Operator<T>.Subtract(a.X, b.X), Operator<T>.Subtract(a.Y, b.Y), a.Z);

    public static Vector3<T> operator *(Vector3<T> a, Vector2<T> b) => new(Operator<T>.Multiply(a.X, b.X), Operator<T>.Multiply(a.Y, b.Y), a.Z);

    public static Vector3<T> operator /(Vector3<T> a, Vector2<T> b) => new(Operator<T>.Divide(a.X, b.X), Operator<T>.Divide(a.Y, b.Y));

    public static Vector3<T> operator /(Vector2<T> a, Vector3<T> b) => new(Operator<T>.Divide(a.X, b.X), Operator<T>.Divide(a.Y, b.Y));

    public void Deconstruct(out T x, out T y, out T z)
    {
        x = X;
        y = Y;
        z = Z;
    }

    public override string ToString() => $"({X}, {Y}, {Z})";

    public Vector3<T> Clamp(Vector3<T> minimum, Vector3<T> maximum)
    {
        if (minimum.X.IsGreaterThan(maximum.X) || minimum.Y.IsGreaterThan(maximum.Y) || minimum.Z.IsGreaterThan(maximum.Z))
            throw new ArgumentException(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax);

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

        var z = Z;
        if (Z.IsLesserThan(minimum.Z))
            z = minimum.Z;
        else if (Z.IsGreaterThan(maximum.Z))
            z = maximum.Z;

        return new Vector3<T>(x, y, z);
    }

    public Vector2<T> ToVector2() => new(X, Y);

    public T LengthSquared()
    {
        var x = Operator<T>.Multiply(X, X);
        var y = Operator<T>.Multiply(Y, Y);
        var z = Operator<T>.Multiply(Z, Z);
        var xy = Operator<T>.Add(x, y);
        return Operator<T>.Add(xy, z);
    }

    public Vector3<T> Cross(Vector3<T> other)
    {
        var x = Operator<T>.Subtract(Operator<T>.Multiply(Y, other.Z), Operator<T>.Multiply(other.Y, Z));
        var y = Operator<T>.Negate(Operator<T>.Subtract(Operator<T>.Multiply(X, other.Z), Operator<T>.Multiply(other.X, Z)));
        var z = Operator<T>.Subtract(Operator<T>.Multiply(X, other.Y), Operator<T>.Multiply(other.X, Y));

        return new Vector3<T>(x, y, z);
    }

    public Vector3<T> Normalize()
    {
        var factor = LengthSquared();
        factor = Operator<T>.Divide((T)(object)1f, factor);
        var x = Operator<T>.Multiply(X, factor);
        var y = Operator<T>.Multiply(Y, factor);
        var z = Operator<T>.Multiply(Z, factor);
        return new Vector3<T>(x, y, z);
    }

    public Direction ToDirection()
    {
        if (Operator<T>.Equal(X, default) && Operator<T>.Equal(Y, default))
            return Direction.None;
        if (Operator<T>.Equal(X, default) && Operator<T>.LessThan(Y, default))
            return Direction.Up;
        if (Operator<T>.GreaterThan(X, default) && Operator<T>.Equal(Y, default))
            return Direction.Right;
        if (Operator<T>.Equal(X, default) && Operator<T>.GreaterThan(Y, default))
            return Direction.Down;
        if (Operator<T>.LessThan(X, default) && Operator<T>.Equal(Y, default))
            return Direction.Left;
        if (Operator<T>.LessThan(X, default) && Operator<T>.LessThan(Y, default))
            return Direction.UpLeft;
        if (Operator<T>.GreaterThan(X, default) && Operator<T>.LessThan(Y, default))
            return Direction.UpRight;
        if (Operator<T>.LessThan(X, default) && Operator<T>.GreaterThan(Y, default))
            return Direction.DownLeft;
        if (Operator<T>.GreaterThan(X, default) && Operator<T>.GreaterThan(Y, default))
            return Direction.DownRight;

        throw new NotSupportedException();
    }

    public static implicit operator Vector3<T>(Vector2<T> value) => new(value.X, value.Y, default);

    public static Vector3<T> FromString(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));

        var xyz = value.Trim('(', ')').Split(',');
        if (xyz.Length is < 2 or > 3) throw new Exception($"Can't create Vector3 : Expecting 2 or 3 values but received {xyz.Length}");

        var x = xyz[0].ParseOrThrow<T>();
        var y = xyz[1].ParseOrThrow<T>();
        var z = xyz.Length == 3 ? xyz[2].ParseOrThrow<T>() : default;

        return new Vector3<T>(x, y, z);
    }
}