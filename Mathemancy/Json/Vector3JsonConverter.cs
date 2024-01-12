namespace ToolBX.Mathemancy.Json;

public sealed class Vector3JsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Vector3<>);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var elementType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(Vector3JsonConverter<>).MakeGenericType(elementType);
        return (JsonConverter?)Activator.CreateInstance(converterType);
    }
}

public sealed class Vector3JsonConverter<T> : VectorJsonConverterBase<Vector3<T>, T> where T : struct, INumber<T>
{
    public override Vector3<T> FromString(string value) => Vector3<T>.FromString(value);

    public override Vector3<T> FromValues(T x, T y, T z) => new(x, y, z);
}