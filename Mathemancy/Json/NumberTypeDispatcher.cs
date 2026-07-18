namespace ToolBX.Mathemancy.Json;

/// <summary>
/// Visits a closed set of <see cref="INumber{TSelf}"/> types with a concrete type argument.
/// </summary>
public interface INumberTypeVisitor<out TResult>
{
    TResult Visit<TNumber>() where TNumber : struct, INumber<TNumber>;
}

/// <summary>
/// Dispatches a runtime numeric <see cref="Type"/> to a generic visitor using a concrete type
/// argument. Unlike <see cref="Type.MakeGenericType"/>, every generic instantiation is statically
/// visible to the trimmer and the AOT compiler, so this is trim- and native-AOT-safe.
/// </summary>
public static class NumberTypeDispatcher
{
    public static TResult Invoke<TResult>(Type numberType, INumberTypeVisitor<TResult> visitor)
    {
        if (numberType == typeof(byte)) return visitor.Visit<byte>();
        if (numberType == typeof(sbyte)) return visitor.Visit<sbyte>();
        if (numberType == typeof(short)) return visitor.Visit<short>();
        if (numberType == typeof(ushort)) return visitor.Visit<ushort>();
        if (numberType == typeof(int)) return visitor.Visit<int>();
        if (numberType == typeof(uint)) return visitor.Visit<uint>();
        if (numberType == typeof(long)) return visitor.Visit<long>();
        if (numberType == typeof(ulong)) return visitor.Visit<ulong>();
        if (numberType == typeof(float)) return visitor.Visit<float>();
        if (numberType == typeof(double)) return visitor.Visit<double>();
        if (numberType == typeof(decimal)) return visitor.Visit<decimal>();
        throw new NotSupportedException($"'{numberType}' is not a supported numeric type for Mathemancy JSON serialization.");
    }
}
