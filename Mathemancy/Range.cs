using System.Numerics;

namespace ToolBX.Mathemancy;

/// <summary>
/// A range between two numeric values.
/// </summary>
public readonly record struct Range<T> where T : struct, INumber<T>
{
    public T Start { get; init; }
    public T End { get; init; }

    public Range(T start, T end)
    {
        if (start > end)
            throw new ArgumentException($"Can't create {nameof(Range<T>)} : {nameof(start)} must be smaller than {nameof(end)} but their values are {start} and {end} respectively.");

        Start = start;
        End = end;
    }

    public bool Contains(T value) => Start <= value && End >= value;

    public override string ToString() => $"Between {Start} and {End}";
}