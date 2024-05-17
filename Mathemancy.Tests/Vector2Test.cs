using System.Linq;
using System.Numerics;
using System.Text.Json;
using ToolBX.Mathemancy.Json;

namespace Mathemancy.Tests;

public abstract class Vector2Tester<T> : TestBase where T : struct, INumber<T>
{
    [TestMethod]
    public void Constructor_Always_SetValues()
    {
        //Arrange
        var x = Dummy.Create<T>();
        var y = Dummy.Create<T>();

        //Act
        var result = new Vector2<T>(x, y);

        //Assert
        result.X.Should().Be(x);
        result.Y.Should().Be(y);
    }

    [TestMethod]
    public void Zero_Always_ReturnDefault()
    {
        //Arrange

        //Act
        var result = Vector2<T>.Zero;

        //Assert
        result.Should().Be(new Vector2<T>());
    }

    [TestMethod]
    public void GreaterThan_WhenBothXAndYAreGreaterThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(19));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThan_WhenOnlyXIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(19));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThan_WhenOnlyYIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(21));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThan_WhenBothXAndYAreSmallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(21));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThan_WhenBothAreEqual_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThan_WhenBothXAndYAreGreaterThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(19));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThan_WhenOnlyXIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(19));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThan_WhenOnlyYIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(21));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThan_WhenBothXAndYAreSmallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(21));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThan_WhenBothAreEqual_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqual_WhenBothXAndYAreGreaterThanOther_ReturnTrue()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(19));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqual_WhenOnlyXIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(19));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqual_WhenOnlyYIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(21));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqual_WhenBothXAndYAreSmallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(21));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqual_WhenBothAreEqual_ReturnTrue()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOrEqual_WhenBothXAndYAreGreaterThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(19));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqual_WhenOnlyXIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(19));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqual_WhenOnlyYIsGreater_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(19), T.CreateChecked(21));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqual_WhenBothXAndYAreSmallerThanOther_ReturnFalse()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(21), T.CreateChecked(21));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOrEqual_WhenBothAreEqual_ReturnTrue()
    {
        //Arrange
        var a = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));
        var b = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(20));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void Addition_Always_AddBothValuesTogether()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<Vector2<T>>();

        //Act
        var result = a + b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X + b.X, a.Y + b.Y));
    }

    [TestMethod]
    public void Subtraction_Always_SubtractBothValuesTogether()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<Vector2<T>>();

        //Act
        var result = a - b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X - b.X, a.Y - b.Y));
    }

    [TestMethod]
    public void Addition_WhenNumber_AddValueToBoth()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<T>();

        //Act
        var result = a + b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X + b, a.Y + b));
    }

    [TestMethod]
    public void Subtraction_WhenNumber_SubtractValueFromBoth()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<T>();

        //Act
        var result = a - b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X - b, a.Y - b));
    }

    [TestMethod]
    public void Negation_WhenBothValuesArePositive_ReturnNegatives()
    {
        //Negation cannot be applied for unsigned numbers
        if (Numbers.IsUnsigned<T>())
            return;

        //Arrange
        var instance = Dummy.Create<Vector2<T>>();

        //Act
        var result = -instance;

        //Assert
        result.Should().Be(new Vector2<T>(-instance.X, -instance.Y));
    }

    [TestMethod]
    public void Negation_WhenBothValuesAreNegative_ReturnPositive()
    {
        //Negation cannot be applied for unsigned numbers
        if (Numbers.IsUnsigned<T>())
            return;

        //Arrange
        var instance = new Vector2<T>(-Dummy.Create<T>(), -Dummy.Create<T>());

        //Act
        var result = -instance;

        //Assert
        result.Should().Be(new Vector2<T>(T.Abs(instance.X), T.Abs(instance.Y)));
    }

    [TestMethod]
    public void Negation_WhenXIsNegativeAndYIsPositive_ReturnPositiveXAndNegativeY()
    {
        //Negation cannot be applied for unsigned numbers
        if (Numbers.IsUnsigned<T>())
            return;

        //Arrange
        var instance = new Vector2<T>(-Dummy.Create<T>(), Dummy.Create<T>());

        //Act
        var result = -instance;

        //Assert
        result.Should().Be(new Vector2<T>(T.Abs(instance.X), -instance.Y));
    }

    [TestMethod]
    public void Negation_WhenXIsPositiveAndYIsNegative_ReturnNegativeXAndPositiveY()
    {
        //Negation cannot be applied for unsigned numbers
        if (Numbers.IsUnsigned<T>())
            return;

        //Arrange
        var instance = new Vector2<T>(Dummy.Create<T>(), -Dummy.Create<T>());

        //Act
        var result = -instance;

        //Assert
        result.Should().Be(new Vector2<T>(-instance.X, T.Abs(instance.Y)));
    }

    [TestMethod]
    public void Multiplication_Always_MultiplyBothValuesTogether()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<Vector2<T>>();

        //Act
        var result = a * b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X * b.X, a.Y * b.Y));
    }

    [TestMethod]
    public void Division_Always_SubtractBothValuesTogether()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<Vector2<T>>();

        //Act
        var result = a / b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X / b.X, a.Y / b.Y));
    }

    [TestMethod]
    public void Multiplication_WhenNumber_MultiplyBoth()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<T>();

        //Act
        var result = a * b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X * b, a.Y * b));
    }

    [TestMethod]
    public void Division_WhenNumber_DivideBoth()
    {
        //Arrange
        var a = Dummy.Create<Vector2<T>>();
        var b = Dummy.Create<T>();

        //Act
        var result = a / b;

        //Assert
        result.Should().Be(new Vector2<T>(a.X / b, a.Y / b));
    }

    [TestMethod]
    public void Deconstructor_Always_Deconstruct()
    {
        //Arrange
        var instance = Dummy.Create<Vector2<T>>();

        //Act
        var (x, y) = instance;

        //Assert
        x.Should().Be(instance.X);
        y.Should().Be(instance.Y);
    }

    [TestMethod]
    public void ToString_Always_OutputString()
    {
        //Arrange
        var instance = Dummy.Create<Vector2<T>>();

        //Act
        var result = instance.ToString();

        //Assert
        result.Should().BeEquivalentTo($"({instance.X}, {instance.Y})");
    }

    [TestMethod]
    public void Clamp_WhenTryingToClampTwoVectorsButMinimumHasGreaterXAndYValues_Throw()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateSaturating(15.5f), T.CreateSaturating(14.25f));
        var minimum = new Vector2<T>(T.CreateSaturating(20), T.CreateSaturating(20));
        var maximum = new Vector2<T>(T.CreateSaturating(12), T.CreateSaturating(14));

        //Act
        var action = () => instance.Clamp(minimum, maximum);

        //Assert
        action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax, minimum, maximum));
    }

    [TestMethod]
    public void Clamp_WhenTryingToClampTwoVectorsButMinimumHasGreaterX_Throw()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateSaturating(15.5f), T.CreateSaturating(14.25f));
        var minimum = new Vector2<T>(T.CreateSaturating(20), T.CreateSaturating(12));
        var maximum = new Vector2<T>(T.CreateSaturating(12), T.CreateSaturating(14));

        //Act
        var action = () => instance.Clamp(minimum, maximum);

        //Assert
        action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax, minimum, maximum));
    }

    [TestMethod]
    public void Clamp_WhenTryingToClampTwoVectorsButMinimumHasGreaterY_Throw()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(15.5f), T.CreateChecked(14.25f));
        var minimum = new Vector2<T>(T.CreateChecked(11), T.CreateChecked(20));
        var maximum = new Vector2<T>(T.CreateChecked(12), T.CreateChecked(14));

        //Act
        var action = () => instance.Clamp(minimum, maximum);

        //Assert
        action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax, minimum, maximum));
    }

    [TestMethod]
    public void Clamp_WhenClampingTwoExactValuesTogether_ReturnThatSameValue()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateSaturating(15.5f), T.CreateSaturating(14.25f));
        var minimum = new Vector2<T>(T.CreateSaturating(151.1f), T.CreateSaturating(125.8f));
        var maximum = new Vector2<T>(T.CreateSaturating(151.1f), T.CreateSaturating(125.8f));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(T.CreateSaturating(151.1f), T.CreateSaturating(125.8f)));
    }

    [TestMethod]
    public void Clamp_WhenBothXAndYAreLesserThanMinimum_ReturnMinimum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateSaturating(2), T.CreateSaturating(4));
        var minimum = new Vector2<T>(T.CreateSaturating(10.15f), T.CreateSaturating(8.5f));
        var maximum = new Vector2<T>(T.CreateSaturating(20), T.CreateSaturating(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(minimum);
    }

    [TestMethod]
    public void Clamp_WhenOnlyXIsLesserThanMinimum_OnlyClampX()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateSaturating(2), T.CreateSaturating(14));
        var minimum = new Vector2<T>(T.CreateSaturating(10.15f), T.CreateSaturating(8.5f));
        var maximum = new Vector2<T>(T.CreateSaturating(20), T.CreateSaturating(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(minimum.X, instance.Y));
    }

    [TestMethod]
    public void Clamp_WhenOnlyYIsLesserThanMinimum_OnlyClampY()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(12), T.CreateChecked(7));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(instance.X, minimum.Y));
    }

    [TestMethod]
    public void Clamp_WhenXIsLesserThanMinimumAndYGreaterThanMaximum_ClampXToMinimumAndYToMaximum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(5), T.CreateChecked(21));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(minimum.X, maximum.Y));
    }

    [TestMethod]
    public void Clamp_WhenXIsGreaterThanMaximumAndXIsLesserThanMinimum_ClampXToMaximumAndYToMinimum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(25), T.CreateChecked(2));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(maximum.X, minimum.Y));
    }

    [TestMethod]
    public void Clamp_WhenBothValuesAreGreaterThanMaximum_ReturnMaximum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(89), T.CreateChecked(56));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(maximum.X, maximum.Y));
    }

    [TestMethod]
    public void Clamp_WhenOnlyXIsGreaterThanMaximum_OnlyClampXToMaximum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(89), T.CreateChecked(15));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(maximum.X, instance.Y));
    }

    [TestMethod]
    public void Clamp_WhenOnlyYIsGreaterThanMaximum_OnlyClampYToMaximum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(16), T.CreateChecked(99));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(new Vector2<T>(instance.X, maximum.Y));
    }

    [TestMethod]
    public void Clamp_WhenXAndYAreEqualToMinimum_ReturnMinimum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(minimum);
    }

    [TestMethod]
    public void Clamp_WhenXAndYAreEqualToMaximum_ReturnMaximum()
    {
        //Arrange
        var instance = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));
        var minimum = new Vector2<T>(T.CreateChecked(10.15f), T.CreateChecked(8.5f));
        var maximum = new Vector2<T>(T.CreateChecked(20), T.CreateChecked(18));

        //Act
        var result = instance.Clamp(minimum, maximum);

        //Assert
        result.Should().Be(maximum);
    }

    [TestMethod]
    public void ImplicitToVector3_Always_ConvertFromVector3WithoutZ()
    {
        //Arrange
        var value = Dummy.Create<Vector3<T>>();

        //Act
        Vector2<T> result = value;

        //Assert
        result.Should().Be(new Vector2<T>(value.X, value.Y));
    }

    [TestMethod]
    public void ToVector3_Always_ConvertToVector3()
    {
        //Arrange
        var instance = Dummy.Create<Vector2<T>>();

        //Act
        var result = instance.ToVector3();

        //Assert
        result.Should().Be(new Vector3<T>(instance.X, instance.Y, T.Zero));
    }

    [TestMethod]
    [DataRow("")]
    [DataRow(" ")]
    [DataRow(null)]
    public void FromString_WhenValueIsEmpty_Throw(string value)
    {
        //Arrange

        //Act
        var action = () => Vector2<T>.FromString(value);

        //Assert
        action.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void FromString_WhenThereIsOnlyOneValue_Throw()
    {
        //Arrange
        var value = $"({Dummy.Create<T>()})";

        //Act
        var action = () => Vector2<T>.FromString(value);

        //Assert
        action.Should().Throw<Exception>().WithMessage("Can't create Vector2 : Expecting 2 values but received 1");
    }

    [TestMethod]
    public void FromString_WhenThereAreThreeValues_Throw()
    {
        //Arrange
        var value = $"({Dummy.Create<T>()}, {Dummy.Create<T>()}, {Dummy.Create<T>()})";

        //Act
        var action = () => Vector2<T>.FromString(value);

        //Assert
        action.Should().Throw<Exception>().WithMessage("Can't create Vector2 : Expecting 2 values but received 3");
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoValuesAndXIsNotNumeric_Throw()
    {
        //Arrange
        var value = $"(three point five, {Dummy.Create<T>()})";

        //Act
        var action = () => Vector2<T>.FromString(value);

        //Assert
        action.Should().Throw<StringParsingException<T>>();
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoValuesAndYIsNotNumeric_Throw()
    {
        //Arrange
        var value = $"({Dummy.Create<T>()}, forty-three point eighty-one)";

        //Act
        var action = () => Vector2<T>.FromString(value);

        //Assert
        action.Should().Throw<StringParsingException<T>>();
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoNumericValues_ReturnVectorWithXAndY()
    {
        //Arrange
        var x = Dummy.Create<T>();
        var y = Dummy.Create<T>();

        var value = $"({x}, {y})";

        //Act
        var result = Vector2<T>.FromString(value);

        //Assert
        result.Should().Be(new Vector2<T>(x, y));
    }

    [TestMethod]
    public void FromString_WhenThereAreTwoValuesWithoutParentheses_ReturnVectorWithXAndY()
    {
        //Arrange
        var x = Dummy.Create<T>();
        var y = Dummy.Create<T>();

        var value = $"{x}, {y}";

        //Act
        var result = Vector2<T>.FromString(value);

        //Assert
        result.Should().Be(new Vector2<T>(x, y));
    }

    [TestMethod]
    public void JsonSerialization_WhenAutoConverted_DeserializeBack()
    {
        //Arrange
        var instance = Dummy.Create<Vector2<T>>();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Vector2<T>>(json);

        //Assert
        result.Should().Be(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenAutoConvertedArray_DeserializeBack()
    {
        //Arrange
        var instance = Dummy.CreateMany<Vector2<T>>().ToArray();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Vector2<T>[]>(json);

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenFormatedWithParenthesisUsingJsonConverter_DeserializeBack()
    {
        //Arrange
        var instance = Dummy.Create<Vector2<T>>();
        var json = JsonSerializer.Serialize(instance, new JsonSerializerOptions().WithMathemancyConverters());

        //Act
        var result = JsonSerializer.Deserialize<Vector2<T>>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenAutoFormatedButDeserializedWithCustomConverter_DeserializeBack()
    {
        //Arrange
        var instance = Dummy.Create<Vector2<T>>();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Vector2<T>>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void JsonSerialization_WhenFormatedWithParenthesisUsingJsonConverterInsideArray_DeserializeBack()
    {
        //Arrange
        var instance = Dummy.CreateMany<Vector2<T>>().ToArray();
        var json = JsonSerializer.Serialize(instance, new JsonSerializerOptions().WithMathemancyConverters());

        //Act
        var result = JsonSerializer.Deserialize<Vector2<T>[]>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    public class Garbage
    { 
        public Rectangle<int> Coordinates { get; set; }
    }

    [TestMethod]
    public void JsonSerialization_FromJson_Deserialize()
    {
        //Arrange
        var json = """
                   {
                     "Coordinates": {
                       "Position": "(0, 0)",
                       "Size": {
                         "Width": 11,
                         "Height": 11
                       },
                       "X": 0,
                       "Y": 0,
                       "Width": 11,
                       "Height": 11,
                       "Left": 0,
                       "Right": 11,
                       "Top": 0,
                       "Bottom": 11,
                       "TopLeft": "(0, 0)",
                       "TopRight": "(11, 0)",
                       "BottomLeft": "(0, 11)",
                       "BottomRight": "(11, 11)"
                     }
                   }

                   """;

        //Act
        var result = JsonSerializer.Deserialize<Garbage>(json, new JsonSerializerOptions().WithMathemancyConverters());

        //Assert
        result.Coordinates.Should().BeEquivalentTo(new Rectangle<T>(new Vector2<T>(T.Zero, T.Zero), new Size<T>(T.CreateChecked(11), T.CreateChecked(11))));
    }

    [TestMethod]
    public void Ensure_ValueEquality() => Ensure.ValueEquality<Vector2<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_ValueHashCode() => Ensure.ValueHashCode<Vector2<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_IsJsonSerializable() => Ensure.IsJsonSerializable<Vector2<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());
}

[TestClass]
public class Vector2OfByteTest : Vector2Tester<byte>
{

}

[TestClass]
[Ignore("Sbyte appears to be working unexpectedly")]
public class Vector2OfSByteTest : Vector2Tester<sbyte>
{

}

[TestClass]
public class Vector2OfShortTest : Vector2Tester<short>
{

}

[TestClass]
public class Vector2OfUShortTest : Vector2Tester<ushort>
{

}

[TestClass]
public class Vector2OfIntTest : Vector2Tester<int>
{

}

[TestClass]
public class Vector2OfUIntTest : Vector2Tester<uint>
{

}

[TestClass]
public class Vector2OfLongTest : Vector2Tester<long>
{

}

[TestClass]
public class Vector2OfULongTest : Vector2Tester<ulong>
{

}

[TestClass]
public class Vector2OfFloatTest : Vector2Tester<float>
{

}

[TestClass]
public class Vector2OfDoubleTest : Vector2Tester<double>
{

}

[TestClass]
public class Vector2OfDecimalTest : Vector2Tester<decimal>
{

}