using System.Numerics;

namespace ToolBX.Mathemancy;

public readonly record struct Boundaries<T>(T Top, T Right, T Bottom, T Left) where T : struct, INumber<T>
{
    public static Boundaries<T> operator -(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = a.Top - b.Top,
            Right = a.Right - b.Right,
            Bottom = a.Bottom - b.Bottom,
            Left = a.Left - b.Left
        };
    }

    public static Boundaries<T> operator +(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = a.Top + b.Top,
            Right = a.Right + b.Right,
            Bottom = a.Bottom + b.Bottom,
            Left = a.Left + b.Left
        };
    }

    public static Boundaries<T> operator *(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = a.Top * b.Top,
            Right = a.Right * b.Right,
            Bottom = a.Bottom * b.Bottom,
            Left = a.Left * b.Left
        };
    }

    public static Boundaries<T> operator /(Boundaries<T> a, Boundaries<T> b)
    {
        return new Boundaries<T>
        {
            Top = a.Top / b.Top,
            Right = a.Right / b.Right,
            Bottom = a.Bottom / b.Bottom,
            Left = a.Left / b.Left
        };
    }

    public static bool operator >(Boundaries<T> a, Boundaries<T> b)
    {
        return a.Top < b.Top &&
               a.Right > b.Right &&
               a.Left < b.Left &&
               a.Bottom > b.Bottom;
    }

    public static bool operator <(Boundaries<T> a, Boundaries<T> b) => !(a >= b);

    public static bool operator >=(Boundaries<T> a, Boundaries<T> b)
    {
        return a.Top <= b.Top &&
               a.Right >= b.Right &&
               a.Left <= b.Left &&
               a.Bottom >= b.Bottom;
    }

    public static bool operator <=(Boundaries<T> a, Boundaries<T> b) => !(a > b);
}