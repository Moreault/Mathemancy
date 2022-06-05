namespace ToolBX.Mathemancy;

/// <summary>
/// A range between two numeric values.
/// </summary>
public readonly record struct Range<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public T Start { get; init; }
    public T End { get; init; }

    public Range(T start, T end)
    {
        if (Operator<T>.GreaterThan(start, end))
            throw new ArgumentException($"Can't create {nameof(Range<T>)} : {nameof(start)} must be smaller than {nameof(end)} but their values are {start} and {end} respectively.");

        Start = start;
        End = end;
    }

    public bool Contains(T value) => Operator<T>.LessThanOrEqual(Start, value) && Operator<T>.GreaterThanOrEqual(End, value);

    public override string ToString() => $"Between {Start} and {End}";
}