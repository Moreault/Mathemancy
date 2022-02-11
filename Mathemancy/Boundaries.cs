using ToolBX.Mathemancy.Expressions;

namespace ToolBX.Mathemancy;

public readonly record struct Boundaries<T>(T Top, T Right, T Bottom, T Left) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public static Boundaries<T> operator -(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = Operator<T>.Subtract(a.Top, b.Top),
            Right = Operator<T>.Subtract(a.Right, b.Right),
            Bottom = Operator<T>.Subtract(a.Bottom, b.Bottom),
            Left = Operator<T>.Subtract(a.Left, b.Left)
        };
    }

    public static Boundaries<T> operator +(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = Operator<T>.Add(a.Top, b.Top),
            Right = Operator<T>.Add(a.Right, b.Right),
            Bottom = Operator<T>.Add(a.Bottom, b.Bottom),
            Left = Operator<T>.Add(a.Left, b.Left)
        };
    }

    public static Boundaries<T> operator *(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = Operator<T>.Multiply(a.Top, b.Top),
            Right = Operator<T>.Multiply(a.Right, b.Right),
            Bottom = Operator<T>.Multiply(a.Bottom, b.Bottom),
            Left = Operator<T>.Multiply(a.Left, b.Left)
        };
    }

    public static Boundaries<T> operator /(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = Operator<T>.Divide(a.Top, b.Top),
            Right = Operator<T>.Divide(a.Right, b.Right),
            Bottom = Operator<T>.Divide(a.Bottom, b.Bottom),
            Left = Operator<T>.Divide(a.Left, b.Left)
        };
    }

    public static bool operator >(Boundaries<T> a, Boundaries<T> b)
    {
        return Operator<T>.LessThan(a.Top, b.Top) &&
               Operator<T>.GreaterThan(a.Right, b.Right) &&
               Operator<T>.LessThan(a.Left, b.Left) &&
               Operator<T>.GreaterThan(a.Bottom, b.Bottom);
    }

    public static bool operator <(Boundaries<T> a, Boundaries<T> b) => !(a >= b);

    public static bool operator >=(Boundaries<T> a, Boundaries<T> b)
    {
        return Operator<T>.LessThanOrEqual(a.Top, b.Top) &&
               Operator<T>.GreaterThanOrEqual(a.Right, b.Right) &&
               Operator<T>.LessThanOrEqual(a.Left, b.Left) &&
               Operator<T>.GreaterThanOrEqual(a.Bottom, b.Bottom);
    }

    public static bool operator <=(Boundaries<T> a, Boundaries<T> b) => !(a > b);
};