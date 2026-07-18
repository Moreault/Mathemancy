namespace Mathemancy.Tests;

public abstract class PolygonTester<T> : Tester where T : struct, INumber<T>
{
    private static Vector2<T> V(int x, int y) => new(T.CreateChecked(x), T.CreateChecked(y));

    [TestMethod]
    public void Constructor_Parameterless_Always_Throws()
    {
        //Arrange

        //Act
        var action = () => new Polygon<T>();

        //Assert
        action.Should().Throw<ArgumentException>().WithParameterName("Vertices");
    }

    [TestMethod]
    public void Constructor_WhenEnumerableHasFewerThanThreeVertices_Throw()
    {
        //Arrange
        var vertices = new List<Vector2<T>> { V(0, 0), V(4, 0) };

        //Act
        var action = () => new Polygon<T>(vertices);

        //Assert
        action.Should().Throw<ArgumentException>().WithParameterName("Vertices")
            .WithMessage($"*{Exceptions.PolygonRequiresThreeVertices}*");
    }

    [TestMethod]
    public void Constructor_WhenSpanHasFewerThanThreeVertices_Throw()
    {
        //Arrange

        //Act
        var action = () => new Polygon<T>(V(0, 0), V(4, 0));

        //Assert
        action.Should().Throw<ArgumentException>().WithParameterName("Vertices");
    }

    [TestMethod]
    public void Constructor_WhenEnumerableHasThreeOrMoreVertices_SetVertices()
    {
        //Arrange
        var vertices = new List<Vector2<T>> { V(1, 1), V(5, 1), V(3, 4) };

        //Act
        var result = new Polygon<T>(vertices);

        //Assert
        result.Should().ContainInOrder(vertices);
    }

    [TestMethod]
    public void Constructor_WhenUsingParams_SetVertices()
    {
        //Arrange

        //Act
        var result = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));

        //Assert
        result.Should().ContainInOrder(V(1, 1), V(5, 1), V(3, 4));
    }

    [TestMethod]
    public void Count_Always_ReturnNumberOfVertices()
    {
        //Arrange
        var polygon = new Polygon<T>(V(1, 1), V(5, 1), V(5, 5), V(1, 5));

        //Act
        var result = polygon.Count;

        //Assert
        result.Should().Be(4);
    }

    [TestMethod]
    public void Indexer_Always_ReturnVertexAtIndex()
    {
        //Arrange
        var polygon = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));

        //Act
        var result = polygon[1];

        //Assert
        result.Should().Be(V(5, 1));
    }

    [TestMethod]
    public void Enumeration_Always_YieldVerticesInOrder()
    {
        //Arrange
        var vertices = new[] { V(1, 1), V(5, 1), V(3, 4) };
        var polygon = new Polygon<T>(vertices);

        //Act
        var result = polygon.ToList();

        //Assert
        result.Should().ContainInOrder(vertices);
    }

    [TestMethod]
    public void Bounds_Always_ReturnRectangleEnclosingAllVertices()
    {
        //Arrange
        var polygon = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));

        //Act
        var result = polygon.Bounds;

        //Assert
        result.Should().Be(new Rectangle<T>(T.CreateChecked(1), T.CreateChecked(1), T.CreateChecked(4), T.CreateChecked(3)));
    }

    [TestMethod]
    public void SignedArea_WhenVerticesAreCounterClockwise_ReturnPositiveArea()
    {
        //Arrange
        var polygon = new Polygon<T>(V(0, 0), V(4, 0), V(4, 4), V(0, 4));

        //Act
        var result = polygon.SignedArea;

        //Assert
        result.Should().Be(T.CreateChecked(16));
    }

    [TestMethod]
    public void IsClockwise_WhenVerticesAreCounterClockwise_ReturnFalse()
    {
        //Arrange
        var polygon = new Polygon<T>(V(0, 0), V(4, 0), V(4, 4), V(0, 4));

        //Act
        var result = polygon.IsClockwise;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void IsClockwise_WhenVerticesAreClockwise_ReturnTrue()
    {
        //Clockwise winding produces a negative signed area which cannot be represented by unsigned numbers
        if (Numbers.IsUnsigned<T>())
            return;

        //Arrange
        var polygon = new Polygon<T>(V(0, 0), V(0, 4), V(4, 4), V(4, 0));

        //Act
        var result = polygon.IsClockwise;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void Equals_WhenOtherHasSameVerticesInSameOrder_ReturnTrue()
    {
        //Arrange
        var a = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));
        var b = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));

        //Act
        var result = a.Equals(b);

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void Equals_WhenOtherHasSameVerticesInDifferentOrder_ReturnFalse()
    {
        //Arrange
        var a = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));
        var b = new Polygon<T>(V(5, 1), V(1, 1), V(3, 4));

        //Act
        var result = a.Equals(b);

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void Equals_WhenOtherHasDifferentVertices_ReturnFalse()
    {
        //Arrange
        var a = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));
        var b = new Polygon<T>(V(1, 1), V(5, 1), V(9, 9));

        //Act
        var result = a.Equals(b);

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GetHashCode_WhenPolygonsAreEqual_ReturnSameHashCode()
    {
        //Arrange
        var a = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));
        var b = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));

        //Act

        //Assert
        a.GetHashCode().Should().Be(b.GetHashCode());
    }

    [TestMethod]
    public void ToString_Always_JoinVerticesWithArrows()
    {
        //Arrange
        var polygon = new Polygon<T>(V(1, 1), V(5, 1), V(3, 4));

        //Act
        var result = polygon.ToString();

        //Assert
        result.Should().Be($"{V(1, 1)} -> {V(5, 1)} -> {V(3, 4)}");
    }

    [TestMethod]
    public void JsonSerialization_WhenUsingMathemancyConverters_DeserializeBack()
    {
        //Arrange
        var instance = Dummy.Create<Polygon<T>>();
        var json = JsonSerializer.Serialize(instance, new JsonSerializerOptions().WithMathemancyConverters());

        //Act
        var result = JsonSerializer.Deserialize<Polygon<T>>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenInsideArrayUsingMathemancyConverters_DeserializeBack()
    {
        //Arrange
        var instance = Dummy.CreateMany<Polygon<T>>().ToArray();
        var json = JsonSerializer.Serialize(instance, new JsonSerializerOptions().WithMathemancyConverters());

        //Act
        var result = JsonSerializer.Deserialize<Polygon<T>[]>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenJsonHasFewerThanThreeVertices_Throw()
    {
        //Arrange
        var vertices = new List<Vector2<T>> { V(0, 0), V(4, 0) };
        var json = JsonSerializer.Serialize(vertices, new JsonSerializerOptions().WithMathemancyConverters());

        //Act
        var action = () => JsonSerializer.Deserialize<Polygon<T>>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        action.Should().Throw<JsonException>();
    }

    [TestMethod]
    public void Ensure_ValueEquality() => Ensure.ValueEquality<Polygon<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_ValueHashCode() => Ensure.ValueHashCode<Polygon<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_IsJsonSerializable() => Ensure.IsJsonSerializable<Polygon<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());
}

[TestClass]
public class PolygonOfByteTest : PolygonTester<byte>;

[TestClass]
public class PolygonOfShortTest : PolygonTester<short>;

[TestClass]
public class PolygonOfUShortTest : PolygonTester<ushort>;

[TestClass]
public class PolygonOfIntTest : PolygonTester<int>;

[TestClass]
public class PolygonOfUIntTest : PolygonTester<uint>;

[TestClass]
public class PolygonOfLongTest : PolygonTester<long>;

[TestClass]
public class PolygonOfULongTest : PolygonTester<ulong>;

[TestClass]
public class PolygonOfFloatTest : PolygonTester<float>;

[TestClass]
public class PolygonOfDoubleTest : PolygonTester<double>;

[TestClass]
public class PolygonOfDecimalTest : PolygonTester<decimal>;
