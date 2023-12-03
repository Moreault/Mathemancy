using System.Numerics;
using ToolBX.EasyTypeParsing;

namespace Mathemancy.Tests;

[TestClass]
public class Vector2Tester
{
    [TestClass]
    public class Constructor : Tester
    {
        [TestMethod]
        public void Always_SetValues()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();

            //Act
            var result = new Vector2<float>(x, y);

            //Assert
            result.X.Should().Be(x);
            result.Y.Should().Be(y);
        }
    }

    [TestClass]
    public class Zero : Tester
    {
        [TestMethod]
        public void Always_ReturnDefault()
        {
            //Arrange

            //Act
            var result = Vector2<float>.Zero;

            //Assert
            result.Should().Be(new Vector2<float>());
        }
    }

    [TestClass]
    public class GreaterThanOperator : Tester
    {
        [TestMethod]
        public void WhenBothXAndYAreGreaterThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 19);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenOnlyXIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 19);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenOnlyYIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 21);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothXAndYAreSmallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 21);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(20, 20);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class LesserThanOperator : Tester
    {
        [TestMethod]
        public void WhenBothXAndYAreGreaterThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 19);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenOnlyXIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 19);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenOnlyYIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 21);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothXAndYAreSmallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 21);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(20, 20);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class GreaterThanOrEqualToOperator : Tester
    {
        [TestMethod]
        public void WhenBothXAndYAreGreaterThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 19);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenOnlyXIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 19);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenOnlyYIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 21);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothXAndYAreSmallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 21);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnTrue()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(20, 20);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class LesserThanOrEqualToOperator : Tester
    {
        [TestMethod]
        public void WhenBothXAndYAreGreaterThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 19);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenOnlyXIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 19);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenOnlyYIsGreater_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(19, 21);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothXAndYAreSmallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(21, 21);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnTrue()
        {
            //Arrange
            var a = new Vector2<float>(20, 20);
            var b = new Vector2<float>(20, 20);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class PlusOperator_Vector : Tester
    {
        [TestMethod]
        public void Always_AddBothValuesTogether()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<Vector2<float>>();

            //Act
            var result = a + b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X + b.X, a.Y + b.Y));
        }
    }

    [TestClass]
    public class MinusOperator_Vector : Tester
    {
        [TestMethod]
        public void Always_SubtractBothValuesTogether()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<Vector2<float>>();

            //Act
            var result = a - b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X - b.X, a.Y - b.Y));
        }
    }

    [TestClass]
    public class PlusOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_AddValueToBoth()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<float>();

            //Act
            var result = a + b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X + b, a.Y + b));
        }
    }

    [TestClass]
    public class MinusOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_SubtractValueFromBoth()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<float>();

            //Act
            var result = a - b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X - b, a.Y - b));
        }
    }

    [TestClass]
    public class NegationOperator : Tester
    {
        [TestMethod]
        public void WhenBothValuesArePositive_ReturnNegatives()
        {
            //Arrange
            var instance = Fixture.Create<Vector2<float>>();

            //Act
            var result = -instance;

            //Assert
            result.Should().Be(new Vector2<float>(-instance.X, -instance.Y));
        }

        [TestMethod]
        public void WhenBothValuesAreNegative_ReturnPositive()
        {
            //Arrange
            var instance = new Vector2<float>(-Fixture.Create<float>(), -Fixture.Create<float>());

            //Act
            var result = -instance;

            //Assert
            result.Should().Be(new Vector2<float>(Math.Abs(instance.X), Math.Abs(instance.Y)));
        }

        [TestMethod]
        public void WhenXIsNegativeAndYIsPositive_ReturnPositiveXAndNegativeY()
        {
            //Arrange
            var instance = new Vector2<float>(-Fixture.Create<float>(), Fixture.Create<float>());

            //Act
            var result = -instance;

            //Assert
            result.Should().Be(new Vector2<float>(Math.Abs(instance.X), -instance.Y));
        }

        [TestMethod]
        public void WhenXIsPositiveAndYIsNegative_ReturnNegativeXAndPositiveY()
        {
            //Arrange
            var instance = new Vector2<float>(Fixture.Create<float>(), -Fixture.Create<float>());

            //Act
            var result = -instance;

            //Assert
            result.Should().Be(new Vector2<float>(-instance.X, Math.Abs(instance.Y)));
        }
    }

    [TestClass]
    public class MultiplyOperator_Vector : Tester
    {
        [TestMethod]
        public void Always_SubtractBothValuesTogether()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<Vector2<float>>();

            //Act
            var result = a * b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X * b.X, a.Y * b.Y));
        }
    }

    [TestClass]
    public class DivideOperator_Vector : Tester
    {
        [TestMethod]
        public void Always_SubtractBothValuesTogether()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<Vector2<float>>();

            //Act
            var result = a / b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X / b.X, a.Y / b.Y));
        }
    }

    [TestClass]
    public class MultiplyOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_SubtractBothValuesTogether()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<float>();

            //Act
            var result = a * b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X * b, a.Y * b));
        }
    }

    [TestClass]
    public class DivideOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_SubtractBothValuesTogether()
        {
            //Arrange
            var a = Fixture.Create<Vector2<float>>();
            var b = Fixture.Create<float>();

            //Act
            var result = a / b;

            //Assert
            result.Should().Be(new Vector2<float>(a.X / b, a.Y / b));
        }
    }

    [TestClass]
    public class Deconstruct : Tester
    {
        [TestMethod]
        public void Always_Deconstruct()
        {
            //Arrange
            var instance = Fixture.Create<Vector2<float>>();

            //Act
            var (x, y) = instance;

            //Assert
            x.Should().Be(instance.X);
            y.Should().Be(instance.Y);
        }
    }

    [TestClass]
    public class ToStringMethod : Tester
    {
        [TestMethod]
        public void Always_OutputString()
        {
            //Arrange
            var instance = Fixture.Create<Vector2<float>>();

            //Act
            var result = instance.ToString();

            //Assert
            result.Should().BeEquivalentTo($"({instance.X}, {instance.Y})");
        }
    }

    [TestClass]
    public class Clamp : Tester
    {
        [TestMethod]
        public void WhenTryingToClampTwoVectorsButMinimumHasGreaterXAndYValues_Throw()
        {
            //Arrange
            var instance = new Vector2<float>(15.5f, 14.25f);
            var minimum = new Vector2<float>(20, 20);
            var maximum = new Vector2<float>(12, 14);

            //Act
            var action = () => instance.Clamp(minimum, maximum);

            //Assert
            action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax, minimum, maximum));
        }

        [TestMethod]
        public void WhenTryingToClampTwoVectorsButMinimumHasGreaterX_Throw()
        {
            //Arrange
            var instance = new Vector2<float>(15.5f, 14.25f);
            var minimum = new Vector2<float>(20, 12);
            var maximum = new Vector2<float>(12, 14);

            //Act
            var action = () => instance.Clamp(minimum, maximum);

            //Assert
            action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax, minimum, maximum));
        }

        [TestMethod]
        public void WhenTryingToClampTwoVectorsButMinimumHasGreaterY_Throw()
        {
            //Arrange
            var instance = new Vector2<float>(15.5f, 14.25f);
            var minimum = new Vector2<float>(11, 20);
            var maximum = new Vector2<float>(12, 14);

            //Act
            var action = () => instance.Clamp(minimum, maximum);

            //Assert
            action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.CannotClampVectorBecauseMinIsLargerThanMax, minimum, maximum));
        }

        [TestMethod]
        public void WhenClampingTwoExactValuesTogether_ReturnThatSameValue()
        {
            //Arrange
            var instance = new Vector2<float>(15.5f, 14.25f);
            var minimum = new Vector2<float>(151.1f, 125.8f);
            var maximum = new Vector2<float>(151.1f, 125.8f);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(151.1f, 125.8f));
        }

        [TestMethod]
        public void WhenBothXAndYAreLesserThanMinimum_ReturnMinimum()
        {
            //Arrange
            var instance = new Vector2<float>(2, 4);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(minimum);
        }

        [TestMethod]
        public void WhenOnlyXIsLesserThanMinimum_OnlyClampX()
        {
            //Arrange
            var instance = new Vector2<float>(2, 14);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(minimum.X, instance.Y));
        }

        [TestMethod]
        public void WhenOnlyYIsLesserThanMinimum_OnlyClampY()
        {
            //Arrange
            var instance = new Vector2<float>(12, 7);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(instance.X, minimum.Y));
        }

        [TestMethod]
        public void WhenXIsLesserThanMinimumAndYGreaterThanMaximum_ClampXToMinimumAndYToMaximum()
        {
            //Arrange
            var instance = new Vector2<float>(5, 21);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(minimum.X, maximum.Y));
        }

        [TestMethod]
        public void WhenXIsGreaterThanMaximumAndXIsLesserThanMinimum_ClampXToMaximumAndYToMinimum()
        {
            //Arrange
            var instance = new Vector2<float>(25, 2);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(maximum.X, minimum.Y));
        }

        [TestMethod]
        public void WhenBothValuesAreGreaterThanMaximum_ReturnMaximum()
        {
            //Arrange
            var instance = new Vector2<float>(89, 56);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(maximum.X, maximum.Y));
        }

        [TestMethod]
        public void WhenOnlyXIsGreaterThanMaximum_OnlyClampXToMaximum()
        {
            //Arrange
            var instance = new Vector2<float>(89, 15);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(maximum.X, instance.Y));
        }

        [TestMethod]
        public void WhenOnlyYIsGreaterThanMaximum_OnlyClampYToMaximum()
        {
            //Arrange
            var instance = new Vector2<float>(16, 99);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(new Vector2<float>(instance.X, maximum.Y));
        }

        [TestMethod]
        public void WhenXAndYAreEqualToMinimum_ReturnMinimum()
        {
            //Arrange
            var instance = new Vector2<float>(10.15f, 8.5f);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(minimum);
        }

        [TestMethod]
        public void WhenXAndYAreEqualToMaximum_ReturnMaximum()
        {
            //Arrange
            var instance = new Vector2<float>(20, 18);
            var minimum = new Vector2<float>(10.15f, 8.5f);
            var maximum = new Vector2<float>(20, 18);

            //Act
            var result = instance.Clamp(minimum, maximum);

            //Assert
            result.Should().Be(maximum);
        }
    }

    [TestClass]
    public class ImplicitOperator_Vector3 : Tester
    {
        [TestMethod]
        public void Always_ConvertFromVector3WithoutZ()
        {
            //Arrange
            var value = Fixture.Create<Vector3<float>>();

            //Act
            Vector2<float> result = value;

            //Assert
            result.Should().Be(new Vector2<float>(value.X, value.Y));
        }
    }

    [TestClass]
    public class ToVector3 : Tester
    {
        //TODO Test
        [TestMethod]
        public void Always_ConvertToVector3()
        {
            //Arrange
            var instance = Fixture.Create<Vector2<float>>();

            //Act
            var result = instance.ToVector3();

            //Assert
            result.Should().Be(new Vector3<float>(instance.X, instance.Y, 0));
        }
    }

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
            var action = () => Vector2<float>.FromString(value);

            //Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void WhenThereIsOnlyOneValue_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()})";

            //Act
            var action = () => Vector2<float>.FromString(value);

            //Assert
            action.Should().Throw<Exception>().WithMessage("Can't create Vector2 : Expecting 2 values but received 1");
        }

        [TestMethod]
        public void WhenThereAreThreeValues_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, {Fixture.Create<float>()}, {Fixture.Create<float>()})";

            //Act
            var action = () => Vector2<float>.FromString(value);

            //Assert
            action.Should().Throw<Exception>().WithMessage("Can't create Vector2 : Expecting 2 values but received 3");
        }

        [TestMethod]
        public void WhenThereAreTwoValuesAndXIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"(three point five, {Fixture.Create<float>()})";

            //Act
            var action = () => Vector2<float>.FromString(value);

            //Assert
            action.Should().Throw<StringParsingException<float>>();
        }

        [TestMethod]
        public void WhenThereAreTwoValuesAndYIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, forty-three point eighty-one)";

            //Act
            var action = () => Vector2<float>.FromString(value);

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
            var result = Vector2<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector2<float>(x, y));
        }

        [TestMethod]
        public void WhenThereAreTwoValuesWithoutParentheses_ReturnVectorWithXAndY()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();

            var value = $"{x}, {y}";

            //Act
            var result = Vector2<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector2<float>(x, y));
        }
    }
}