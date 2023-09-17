using ToolBX.EasyTypeParsing;

namespace Mathemancy.Tests;

[TestClass]
public class Vector3Tester
{
    [TestClass]
    public class FromString : Tester
    {
        [TestMethod]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow(null)]
        public void WhenValueIsEmpty_Throw(string value)
        {
            //Arrange

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void WhenThereIsOnlyOneValue_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()})";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<Exception>().WithMessage($"Can't create Vector3 : Expecting 2 or 3 values but received 1");
        }

        [TestMethod]
        public void WhenThereAreFourValues_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, {Fixture.Create<float>()}, {Fixture.Create<float>()}, {Fixture.Create<float>()})";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<Exception>().WithMessage($"Can't create Vector3 : Expecting 2 or 3 values but received 4");
        }

        [TestMethod]
        public void WhenThereAreTwoValuesAndXIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"(three point five, {Fixture.Create<float>()})";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<StringParsingException<float>>();
        }

        [TestMethod]
        public void WhenThereAreTwoValuesAndYIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, forty-three point eighty-one)";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<StringParsingException<float>>();
        }

        [TestMethod]
        public void WhenThereAreTwoNumericValues_ReturnVectorWithXAndY()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();

            var value = $"({x}, {y})";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y));
        }

        [TestMethod]
        public void WhenThereAreThreeValuesAndZIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, {Fixture.Create<float>()}, forty-three point eighty-one)";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<StringParsingException<float>>();
        }

        [TestMethod]
        public void WhenThereAreThreeNumericValues_ReturnVectorWithXYZ()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();
            var z = Fixture.Create<float>();

            var value = $"({x}, {y}, {z})";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y, z));
        }

        [TestMethod]
        public void WhenThereAreTwoValuesWithoutParentheses_ReturnVectorWithXAndY()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();

            var value = $"{x}, {y}";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y));
        }

        [TestMethod]
        public void WhenThereAreThreeValuesWithoutParentheses_ReturnVectorWithXYZ()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();
            var z = Fixture.Create<float>();

            var value = $"{x}, {y}, {z}";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y, z));
        }
    }

    [TestClass]
    public class Addition : Tester
    {
        [TestMethod]
        public void WhenBothVector3_AddBothXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector3<float>>();

            //Act
            var result = instance + other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X + other.X, +instance.Y + other.Y, instance.Z + other.Z));
        }

        [TestMethod]
        public void WhenOtherIsVector2_AddBothXYWithZeroForZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector2<float>>();

            //Act
            var result = instance + other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X + other.X, +instance.Y + other.Y, instance.Z));
        }

        [TestMethod]
        public void WhenOtherIsNumber_AddNumberToXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<float>();

            //Act
            var result = instance + other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X + other, +instance.Y + other, instance.Z + other));
        }
    }

    [TestClass]
    public class Subtraction : Tester
    {
        [TestMethod]
        public void WhenBothVector3_SubtractBothXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector3<float>>();

            //Act
            var result = instance - other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X - other.X, +instance.Y - other.Y, instance.Z - other.Z));
        }

        [TestMethod]
        public void WhenOtherIsVector2_SubtractBothXYWithZeroForZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector2<float>>();

            //Act
            var result = instance - other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X - other.X, +instance.Y - other.Y, instance.Z));
        }

        [TestMethod]
        public void WhenOtherIsNumber_SubtractNumberToXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<float>();

            //Act
            var result = instance - other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X - other, +instance.Y - other, instance.Z - other));
        }
    }

    [TestClass]
    public class Multiplication : Tester
    {
        [TestMethod]
        public void WhenBothVector3_MultiplyBothXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector3<float>>();

            //Act
            var result = instance * other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X * other.X, +instance.Y * other.Y, instance.Z * other.Z));
        }

        [TestMethod]
        public void WhenOtherIsVector2_MultiplyBothXYWithZeroForZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector2<float>>();

            //Act
            var result = instance * other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X * other.X, +instance.Y * other.Y, instance.Z));
        }

        [TestMethod]
        public void WhenOtherIsNumber_MultiplyNumberToXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<float>();

            //Act
            var result = instance * other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X * other, +instance.Y * other, instance.Z * other));
        }
    }

    [TestClass]
    public class Division : Tester
    {
        [TestMethod]
        public void WhenDividingVector3ByVector3_DivideBothXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector3<float>>();

            //Act
            var result = instance / other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X / other.X, instance.Y / other.Y, instance.Z / other.Z));
        }

        [TestMethod]
        public void WhenDividingVector3ByVector2_DivideBothXYAndSetZToZero()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector2<float>>();

            //Act
            var result = instance / other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X / other.X, instance.Y / other.Y, 0));
        }

        [TestMethod]
        public void WhenDividingVector2ByVector3_DivideBothXYAndSetZToZero()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<Vector2<float>>();

            //Act
            var result = other / instance;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(other.X / instance.X, other.Y / instance.Y, 0));
        }

        [TestMethod]
        public void WhenDividingVector3ByNumber_DivideNumberToXYZ()
        {
            //Arrange
            var instance = Fixture.Create<Vector3<float>>();
            var other = Fixture.Create<float>();

            //Act
            var result = instance / other;

            //Assert
            result.Should().BeEquivalentTo(new Vector3<float>(instance.X / other, instance.Y / other, instance.Z / other));
        }
    }
}