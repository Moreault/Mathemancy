using System.Numerics;

namespace ToolBX.Mathemancy;

public readonly record struct Matrix<T> where T : struct, INumber<T>
{
    public static Matrix<T> Identity = new()
    {
        M11 = (T)(object)1f,
        M12 = (T)(object)0f,
        M13 = (T)(object)0f,
        M14 = (T)(object)0f,
        M21 = (T)(object)0f,
        M22 = (T)(object)1f,
        M23 = (T)(object)0f,
        M24 = (T)(object)0f,
        M31 = (T)(object)0f,
        M32 = (T)(object)0f,
        M33 = (T)(object)1f,
        M34 = (T)(object)0f,
        M41 = (T)(object)0f,
        M42 = (T)(object)0f,
        M43 = (T)(object)0f,
        M44 = (T)(object)1f
    };

    /// <summary>
    /// A first row and first column value.
    /// </summary>
    public T M11 { get; init; }

    /// <summary>
    /// A first row and second column value.
    /// </summary>
    public T M12 { get; init; }

    /// <summary>
    /// A first row and third column value.
    /// </summary>
    public T M13 { get; init; }

    /// <summary>
    /// A first row and fourth column value.
    /// </summary>
    public T M14 { get; init; }

    /// <summary>
    /// A second row and first column value.
    /// </summary>
    public T M21 { get; init; }

    /// <summary>
    /// A second row and second column value.
    /// </summary>
    public T M22 { get; init; }

    /// <summary>
    /// A second row and third column value.
    /// </summary>
    public T M23 { get; init; }

    /// <summary>
    /// A second row and fourth column value.
    /// </summary>
    public T M24 { get; init; }

    /// <summary>
    /// A third row and first column value.
    /// </summary>
    public T M31 { get; init; }

    /// <summary>
    /// A third row and second column value.
    /// </summary>
    public T M32 { get; init; }

    /// <summary>
    /// A third row and third column value.
    /// </summary>
    public T M33 { get; init; }

    /// <summary>
    /// A third row and fourth column value.
    /// </summary>
    public T M34 { get; init; }

    /// <summary>
    /// A fourth row and first column value.
    /// </summary>
    public T M41 { get; init; }

    /// <summary>
    /// A fourth row and second column value.
    /// </summary>
    public T M42 { get; init; }

    /// <summary>
    /// A fourth row and third column value.
    /// </summary>
    public T M43 { get; init; }

    /// <summary>
    /// A fourth row and fourth column value.
    /// </summary>
    public T M44 { get; init; }

    public T this[int index]
    {
        get
        {
            switch (index)
            {
                case 0: return M11;
                case 1: return M12;
                case 2: return M13;
                case 3: return M14;
                case 4: return M21;
                case 5: return M22;
                case 6: return M23;
                case 7: return M24;
                case 8: return M31;
                case 9: return M32;
                case 10: return M33;
                case 11: return M34;
                case 12: return M41;
                case 13: return M42;
                case 14: return M43;
                case 15: return M44;
            }
            throw new ArgumentOutOfRangeException();
        }
    }

    public T this[int row, int column] => this[row * 4 + column];

    public Vector3<T> Backward => new(M31, M32, M33);

    public Vector3<T> Down => new(-M21, -M22, -M23);

    public Vector3<T> Forward => new(-M31, -M32, -M33);

    public Vector3<T> Left => new(-M11, -M12, -M13);

    public Vector3<T> Right => new(M11, M12, M13);

    public Vector3<T> Translation => new(M41, M42, M43);

    public Vector3<T> Up => new(M21, M22, M23);

    public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b) => new()
    {
        M11 = a.M11 + b.M11,
        M12 = a.M12 + b.M12,
        M13 = a.M13 + b.M13,
        M14 = a.M14 + b.M14,
        M21 = a.M21 + b.M21,
        M22 = a.M22 + b.M22,
        M23 = a.M23 + b.M23,
        M24 = a.M24 + b.M24,
        M31 = a.M31 + b.M31,
        M32 = a.M32 + b.M32,
        M33 = a.M33 + b.M33,
        M34 = a.M34 + b.M34,
        M41 = a.M41 + b.M41,
        M42 = a.M42 + b.M42,
        M43 = a.M43 + b.M43,
        M44 = a.M44 + b.M44,
    };
}