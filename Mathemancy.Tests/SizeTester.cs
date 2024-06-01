namespace Mathemancy.Tests;

[TestClass]
public class SizeOfIntTests : SizeTester<int>;

[TestClass]
public class SizeOfFloatTests : SizeTester<float>;

public abstract class SizeTester<TNumber> : Tester where TNumber : struct, INumber<TNumber>
{
    [TestMethod]
    public void Constructor_Always_SetValues()
    {
        //Arrange
        var width = Dummy.Create<TNumber>();
        var height = Dummy.Create<TNumber>();

        //Act
        var result = new Size<TNumber>(width, height);

        //Assert
        result.Should().Be(new Size<TNumber>
        {
            Width = width,
            Height = height
        });
    }

    [TestMethod]
    public void CompareToSize_WhenThisIsBiggerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var other = new Size<TNumber>(TNumber.CreateSaturating(9), TNumber.CreateSaturating(8));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToSize_WhenThisIsShorterButLargerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(6));
        var other = new Size<TNumber>(TNumber.CreateSaturating(9), TNumber.CreateSaturating(8));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToSize_WhenThisIsTallerButThinnerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(10));
        var other = new Size<TNumber>(TNumber.CreateSaturating(9), TNumber.CreateSaturating(8));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToSize_WhenOtherIsBiggerThanThis_ReturnMinusOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var other = new Size<TNumber>(TNumber.CreateSaturating(15), TNumber.CreateSaturating(15));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(-1);
    }

    [TestMethod]
    public void CompareToSize_WhenOtherIsShorterButLargerThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var other = new Size<TNumber>(TNumber.CreateSaturating(15), TNumber.CreateSaturating(9));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToSize_WhenOtherIsTallerButThinnerThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var other = new Size<TNumber>(TNumber.CreateSaturating(7), TNumber.CreateSaturating(15));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToSize_WhenThisIsEqualToOther_ReturnZero()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var other = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsNull_ReturnZero()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = null!;

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsNotTheSameGenericType_ReturnZero()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = typeof(TNumber) == typeof(double) ? new Size<float>(9, 8) : new Size<double>(9, 8);

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsNotSize_ReturnZero()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = Dummy.Create<long>();

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void CompareToObject_WhenThisIsBiggerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = new Size<TNumber>(TNumber.CreateSaturating(9), TNumber.CreateSaturating(8));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenThisIsShorterButLargerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(6));
        object other = new Size<TNumber>(TNumber.CreateSaturating(9), TNumber.CreateSaturating(8));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenThisIsTallerButThinnerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(10));
        object other = new Size<TNumber>(TNumber.CreateSaturating(9), TNumber.CreateSaturating(8));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsBiggerThanThis_ReturnMinusOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = new Size<TNumber>(TNumber.CreateSaturating(15), TNumber.CreateSaturating(15));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(-1);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsShorterButLargerThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = new Size<TNumber>(TNumber.CreateSaturating(15), TNumber.CreateSaturating(9));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsTallerButThinnerThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = new Size<TNumber>(TNumber.CreateSaturating(7), TNumber.CreateSaturating(15));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenThisIsEqualToOther_ReturnZero()
    {
        //Arrange
        var instance = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        object other = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void PlusOperatorSize_Always_AddWidthAndHeightTogether()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<Size<TNumber>>();

        //Act
        var result = a + b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width + b.Width, a.Height + b.Height));
    }

    [TestMethod]
    public void MinusOperatorSize_Always_SubtractWidthAndHeightTogether()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<Size<TNumber>>();

        //Act
        var result = a - b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width - b.Width, a.Height - b.Height));
    }

    [TestMethod]
    public void PlusOperatorGeneric_Always_AddValueToBothWidthAndHeight()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<TNumber>();

        //Act
        var result = a + b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width + b, a.Height + b));
    }

    [TestMethod]
    public void MinusOperatorGeneric_Always_AddValueToBothWidthAndHeight()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<TNumber>();

        //Act
        var result = a - b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width - b, a.Height - b));
    }

    [TestMethod]
    public void MultiplyOperatorSize_Always_MultiplyWidthAndHeightTogether()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<Size<TNumber>>();

        //Act
        var result = a * b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width * b.Width, a.Height * b.Height));
    }

    [TestMethod]
    public void MultiplyOperatorGeneric_Always_MultiplyWidthAndHeightTogether()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<TNumber>();

        //Act
        var result = a * b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width * b, a.Height * b));
    }

    [TestMethod]
    public void DivideOperatorSize_Always_MultiplyWidthAndHeightTogether()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<Size<TNumber>>();

        //Act
        var result = a / b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width / b.Width, a.Height / b.Height));
    }

    [TestMethod]
    public void DivideOperatorGeneric_Always_MultiplyWidthAndHeightTogether()
    {
        //Arrange
        var a = Dummy.Create<Size<TNumber>>();
        var b = Dummy.Create<TNumber>();

        //Act
        var result = a / b;

        //Assert
        result.Should().Be(new Size<TNumber>(a.Width / b, a.Height / b));
    }

    [TestMethod]
    public void GreaterThanOperator_WhenThisIsBiggerThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOperator_WhenThisIsLargerButShorterThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(12));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOperator_WhenThisIsThinnerButTallerThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(11), TNumber.CreateSaturating(8));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOperator_WhenThisIsSmallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(7), TNumber.CreateSaturating(6));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOperator_WhenBothAreEqual_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperator_WhenThisIsBiggerThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperator_WhenThisIsLargerButShorterThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(12));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperator_WhenThisIsThinnerButTallerThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(11), TNumber.CreateSaturating(8));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperator_WhenThisIsSmallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(7), TNumber.CreateSaturating(6));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperator_WhenBothAreEqual_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOperator_WhenThisIsBiggerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperator_WhenThisIsLargerButShorterThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(12));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperator_WhenThisIsThinnerButTallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(11), TNumber.CreateSaturating(8));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperator_WhenThisIsSmallerThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(7), TNumber.CreateSaturating(6));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOperator_WhenBothAreEqual_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperator_WhenThisIsBiggerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperator_WhenThisIsLargerButShorterThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(12));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperator_WhenThisIsThinnerButTallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(11), TNumber.CreateSaturating(8));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperator_WhenThisIsSmallerThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(7), TNumber.CreateSaturating(6));
        var b = new Size<TNumber>(TNumber.CreateSaturating(8), TNumber.CreateSaturating(8));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperator_WhenBothAreEqual_ReturnFalse()
    {
        //Arrange
        var a = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));
        var b = new Size<TNumber>(TNumber.CreateSaturating(10), TNumber.CreateSaturating(10));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestClass]
    public class ToStringMethod : Tester
    {
        [TestMethod]
        public void Always_ReturnValues()
        {
            //Arrange
            var instance = Dummy.Create<Size<TNumber>>();

            //Act
            var result = instance.ToString();

            //Assert
            result.Should().Be($"{instance.Width}x{instance.Height}");
        }
    }

    [TestMethod]
    public void Size3DOperator_Always_ConvertToSize3D()
    {
        //Arrange
        var instance = Dummy.Create<Size<TNumber>>();

        //Act
        Size3D<TNumber> result = instance;

        //Assert
        result.Should().BeEquivalentTo(new Size3D<TNumber> { Length = instance.Width, Width = instance.Height });
    }

    [TestMethod]
    public void JsonSerialization_WhenSerializedWithDefaultAndDeserializedWithCustom_ConvertProperly()
    {
        //Arrange
        var instance = Dummy.Create<Size<TNumber>>();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Size<TNumber>>(json, JsonSerializerOptions.WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void Ensure_ValueEquality() => Ensure.ValueEquality<Size<TNumber>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_ValueHashCode() => Ensure.ValueHashCode<Size<TNumber>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_IsJsonSerializable() => Ensure.IsJsonSerializable<Size<TNumber>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_IsJsonSerializableByDefault() => Ensure.IsJsonSerializable<Size<TNumber>>(Dummy);
}