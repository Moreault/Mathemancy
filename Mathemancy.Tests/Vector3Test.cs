using System.Linq;
using System.Numerics;
using System.Text.Json;
using ToolBX.Mathemancy.Json;

namespace Mathemancy.Tests;

public abstract class Vector3Tester<T> : Tester where T : struct, INumber<T>
{
    [TestMethod]
    public void Addition_WhenBothVector3_AddBothXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector3<T>>();

        //Act
        var result = instance + other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X + other.X, +instance.Y + other.Y, instance.Z + other.Z));
    }

    [TestMethod]
    public void Addition_WhenOtherIsVector2_AddBothXYWithZeroForZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector2<T>>();

        //Act
        var result = instance + other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X + other.X, +instance.Y + other.Y, instance.Z));
    }

    [TestMethod]
    public void Addition_WhenOtherIsNumber_AddNumberToXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<T>();

        //Act
        var result = instance + other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X + other, +instance.Y + other, instance.Z + other));
    }

    [TestMethod]
    public void Subtraction_WhenBothVector3_SubtractBothXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector3<T>>();

        //Act
        var result = instance - other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X - other.X, +instance.Y - other.Y, instance.Z - other.Z));
    }

    [TestMethod]
    public void Subtraction_WhenOtherIsVector2_SubtractBothXYWithZeroForZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector2<T>>();

        //Act
        var result = instance - other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X - other.X, +instance.Y - other.Y, instance.Z));
    }

    [TestMethod]
    public void Subtraction_WhenOtherIsNumber_SubtractNumberToXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<T>();

        //Act
        var result = instance - other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X - other, +instance.Y - other, instance.Z - other));
    }

    [TestMethod]
    public void Multiplication_WhenBothVector3_MultiplyBothXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector3<T>>();

        //Act
        var result = instance * other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X * other.X, +instance.Y * other.Y, instance.Z * other.Z));
    }

    [TestMethod]
    public void Multiplication_WhenOtherIsVector2_MultiplyBothXYWithZeroForZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector2<T>>();

        //Act
        var result = instance * other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X * other.X, +instance.Y * other.Y, instance.Z));
    }

    [TestMethod]
    public void Multiplication_WhenOtherIsNumber_MultiplyNumberToXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<T>();

        //Act
        var result = instance * other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X * other, +instance.Y * other, instance.Z * other));
    }

    [TestMethod]
    public void Division_WhenDividingVector3ByVector3_DivideBothXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector3<T>>();

        //Act
        var result = instance / other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X / other.X, instance.Y / other.Y, instance.Z / other.Z));
    }

    [TestMethod]
    public void Division_WhenDividingVector3ByVector2_DivideBothXYAndSetZToZero()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector2<T>>();

        //Act
        var result = instance / other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X / other.X, instance.Y / other.Y, T.Zero));
    }

    [TestMethod]
    public void Division_WhenDividingVector2ByVector3_DivideBothXYAndSetZToZero()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<Vector2<T>>();

        //Act
        var result = other / instance;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(other.X / instance.X, other.Y / instance.Y, T.Zero));
    }

    [TestMethod]
    public void Division_WhenDividingVector3ByNumber_DivideNumberToXYZ()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var other = Fixture.Create<T>();

        //Act
        var result = instance / other;

        //Assert
        result.Should().BeEquivalentTo(new Vector3<T>(instance.X / other, instance.Y / other, instance.Z / other));
    }

    [TestMethod]
    public void FromString_WhenValueIsEmpty_Throw() => Ensure.WhenIsNullOrWhiteSpace(value =>
    {
        //Arrange

        //Act
        var action = () => Vector3<T>.FromString(value);

        //Assert
        action.Should().Throw<ArgumentNullException>();
    });

    [TestMethod]
    public void FromString_WhenThereIsOnlyOneValue_Throw()
    {
        //Arrange
        var value = $"({Fixture.Create<T>()})";

        //Act
        var action = () => Vector3<T>.FromString(value);

        //Assert
        action.Should().Throw<Exception>().WithMessage($"Can't create Vector3 : Expecting 2 or 3 values but received 1");
    }

    [TestMethod]
    public void FromString_WhenThereAreFourValues_Throw()
    {
        //Arrange
        var value = $"({Fixture.Create<T>()}, {Fixture.Create<T>()}, {Fixture.Create<T>()}, {Fixture.Create<T>()})";

        //Act
        var action = () => Vector3<T>.FromString(value);

        //Assert
        action.Should().Throw<Exception>().WithMessage($"Can't create Vector3 : Expecting 2 or 3 values but received 4");
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoValuesAndXIsNotNumeric_Throw()
    {
        //Arrange
        var value = $"(three point five, {Fixture.Create<T>()})";

        //Act
        var action = () => Vector3<T>.FromString(value);

        //Assert
        action.Should().Throw<StringParsingException<T>>();
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoValuesAndYIsNotNumeric_Throw()
    {
        //Arrange
        var value = $"({Fixture.Create<T>()}, forty-three point eighty-one)";

        //Act
        var action = () => Vector3<T>.FromString(value);

        //Assert
        action.Should().Throw<StringParsingException<T>>();
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoNumericValues_ReturnVectorWithXAndY()
    {
        //Arrange
        var x = Fixture.Create<T>();
        var y = Fixture.Create<T>();

        var value = $"({x}, {y})";

        //Act
        var result = Vector3<T>.FromString(value);

        //Assert
        result.Should().Be(new Vector3<T>(x, y));
    }

    [TestMethod]
    public void FromString_WhenThereAreThreeValuesAndZIsNotNumeric_Throw()
    {
        //Arrange
        var value = $"({Fixture.Create<T>()}, {Fixture.Create<T>()}, forty-three point eighty-one)";

        //Act
        var action = () => Vector3<T>.FromString(value);

        //Assert
        action.Should().Throw<StringParsingException<T>>();
    }

    [TestMethod]
    public void WhenThereAreThreeNumericValues_ReturnVectorWithXYZ()
    {
        //Arrange
        var x = Fixture.Create<T>();
        var y = Fixture.Create<T>();
        var z = Fixture.Create<T>();

        var value = $"({x}, {y}, {z})";

        //Act
        var result = Vector3<T>.FromString(value);

        //Assert
        result.Should().Be(new Vector3<T>(x, y, z));
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoValuesWithoutParentheses_ReturnVectorWithXAndY()
    {
        //Arrange
        var x = Fixture.Create<T>();
        var y = Fixture.Create<T>();

        var value = $"{x}, {y}";

        //Act
        var result = Vector3<T>.FromString(value);

        //Assert
        result.Should().Be(new Vector3<T>(x, y));
    }

    [TestMethod]
    public void FromString_WhenThereAreThreeValuesWithoutParentheses_ReturnVectorWithXYZ()
    {
        //Arrange
        var x = Fixture.Create<T>();
        var y = Fixture.Create<T>();
        var z = Fixture.Create<T>();

        var value = $"{x}, {y}, {z}";

        //Act
        var result = Vector3<T>.FromString(value);

        //Assert
        result.Should().Be(new Vector3<T>(x, y, z));
    }

    [TestMethod]
    public void JsonSerialization_WhenAutoConverted_DeserializeBack()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Vector3<T>>(json);

        //Assert
        result.Should().Be(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenAutoConvertedArray_DeserializeBack()
    {
        //Arrange
        var instance = Fixture.CreateMany<Vector3<T>>().ToArray();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Vector3<T>[]>(json);

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenFormatedWithParenthesisUsingJsonConverter_DeserializeBack()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var json = JsonSerializer.Serialize(instance, new JsonSerializerOptions().WithMathemancyConverters());

        //Act
        var result = JsonSerializer.Deserialize<Vector3<T>>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenAutoFormatedButDeserializedWithCustomConverter_DeserializeBack()
    {
        //Arrange
        var instance = Fixture.Create<Vector3<T>>();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Vector3<T>>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenFormatedWithParenthesisUsingJsonConverterInsideArray_DeserializeBack()
    {
        //Arrange
        var instance = Fixture.CreateMany<Vector3<T>>().ToArray();
        var json = JsonSerializer.Serialize(instance, new JsonSerializerOptions().WithMathemancyConverters());

        //Act
        var result = JsonSerializer.Deserialize<Vector3<T>[]>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    //TODO Test serialization same as with Vector2
}

[TestClass]
public class Vector3OfByteTest : Vector3Tester<byte>
{

}

[TestClass]
public class Vector3OfSByteTest : Vector3Tester<sbyte>
{

}

[TestClass]
public class Vector3OfShortTest : Vector3Tester<short>
{

}

[TestClass]
public class Vector3OfUShortTest : Vector3Tester<ushort>
{

}

[TestClass]
public class Vector3OfIntTest : Vector3Tester<int>
{

}

[TestClass]
public class Vector3OfUIntTest : Vector3Tester<uint>
{

}

[TestClass]
public class Vector3OfLongTest : Vector3Tester<long>
{

}

[TestClass]
public class Vector3OfULongTest : Vector3Tester<ulong>
{

}

[TestClass]
public class Vector3OfFloatTest : Vector3Tester<float>
{

}

[TestClass]
public class Vector3OfDoubleTest : Vector3Tester<double>
{

}

[TestClass]
public class Vector3OfDecimalTest : Vector3Tester<decimal>
{

}