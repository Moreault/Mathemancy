using System.Runtime.InteropServices.ComTypes;

namespace Mathemancy.Tests;

[TestClass]
public class SizeTester
{
    [TestClass]
    public class Constructors : Tester
    {
        [TestMethod]
        public void Always_SetValues()
        {
            //Arrange
            var width = Fixture.Create<double>();
            var height = Fixture.Create<double>();

            //Act
            var result = new Size<double>(width, height);

            //Assert
            result.Should().Be(new Size<double>
            {
                Width = width,
                Height = height
            });
        }
    }

    [TestClass]
    public class CompareTo_Size : Tester
    {
        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Size<float>(10, 10);
            var other = new Size<float>(9, 8);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsShorterButLargerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Size<long>(10, 6);
            var other = new Size<long>(9, 8);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsTallerButThinnerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Size<int>(8, 10);
            var other = new Size<int>(9, 8);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsBiggerThanThis_ReturnMinusOne()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            var other = new Size<int>(15, 15);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(-1);
        }

        [TestMethod]
        public void WhenOtherIsShorterButLargerThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            var other = new Size<int>(15, 9);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsTallerButThinnerThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            var other = new Size<int>(7, 15);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsEqualToOther_ReturnZero()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            var other = new Size<int>(10, 10);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }
    }

    [TestClass]
    public class CompareTo_Object : Tester
    {
        [TestMethod]
        public void WhenOtherIsNull_ReturnZero()
        {
            //Arrange
            var instance = new Size<float>(10, 10);
            object other = null!;

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void WhenOtherIsNotTheSameGenericType_ReturnZero()
        {
            //Arrange
            var instance = new Size<float>(10, 10);
            object other = new Size<double>(9, 8);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void WhenOtherIsNotSize_ReturnZero()
        {
            //Arrange
            var instance = new Size<float>(10, 10);
            object other = Fixture.Create<long>();

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Size<float>(10, 10);
            object other = new Size<float>(9, 8);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsShorterButLargerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Size<long>(10, 6);
            object other = new Size<long>(9, 8);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsTallerButThinnerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Size<int>(8, 10);
            object other = new Size<int>(9, 8);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsBiggerThanThis_ReturnMinusOne()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            object other = new Size<int>(15, 15);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(-1);
        }

        [TestMethod]
        public void WhenOtherIsShorterButLargerThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            object other = new Size<int>(15, 9);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsTallerButThinnerThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            object other = new Size<int>(7, 15);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsEqualToOther_ReturnZero()
        {
            //Arrange
            var instance = new Size<int>(10, 10);
            object other = new Size<int>(10, 10);

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }
    }

    [TestClass]
    public class PlusOperator_Size : Tester
    {
        [TestMethod]
        public void Always_AddWidthAndHeightTogether()
        {
            //Arrange
            var a = Fixture.Create<Size<int>>();
            var b = Fixture.Create<Size<int>>();

            //Act
            var result = a + b;

            //Assert
            result.Should().Be(new Size<int>(a.Width + b.Width, a.Height + b.Height));
        }
    }

    [TestClass]
    public class MinusOperator_Size : Tester
    {
        [TestMethod]
        public void Always_SubtractWidthAndHeightTogether()
        {
            //Arrange
            var a = Fixture.Create<Size<int>>();
            var b = Fixture.Create<Size<int>>();

            //Act
            var result = a - b;

            //Assert
            result.Should().Be(new Size<int>(a.Width - b.Width, a.Height - b.Height));
        }
    }

    [TestClass]
    public class PlusOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_AddValueToBothWidthAndHeight()
        {
            //Arrange
            var a = Fixture.Create<Size<int>>();
            var b = Fixture.Create<int>();

            //Act
            var result = a + b;

            //Assert
            result.Should().Be(new Size<int>(a.Width + b, a.Height + b));
        }
    }

    [TestClass]
    public class MinusOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_AddValueToBothWidthAndHeight()
        {
            //Arrange
            var a = Fixture.Create<Size<int>>();
            var b = Fixture.Create<int>();

            //Act
            var result = a - b;

            //Assert
            result.Should().Be(new Size<int>(a.Width - b, a.Height - b));
        }
    }

    [TestClass]
    public class MultiplyOperator_Size : Tester
    {
        [TestMethod]
        public void Always_MultiplyWidthAndHeightTogether()
        {
            //Arrange
            var a = Fixture.Create<Size<int>>();
            var b = Fixture.Create<Size<int>>();

            //Act
            var result = a * b;

            //Assert
            result.Should().Be(new Size<int>(a.Width * b.Width, a.Height * b.Height));
        }
    }

    [TestClass]
    public class MultiplyOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_MultiplyWidthAndHeightTogether()
        {
            //Arrange
            var a = Fixture.Create<Size<int>>();
            var b = Fixture.Create<int>();

            //Act
            var result = a * b;

            //Assert
            result.Should().Be(new Size<int>(a.Width * b, a.Height * b));
        }
    }

    [TestClass]
    public class DivideOperator_Size : Tester
    {
        [TestMethod]
        public void Always_MultiplyWidthAndHeightTogether()
        {
            //Arrange
            var a = Fixture.Create<Size<double>>();
            var b = Fixture.Create<Size<double>>();

            //Act
            var result = a / b;

            //Assert
            result.Should().Be(new Size<double>(a.Width / b.Width, a.Height / b.Height));
        }
    }

    [TestClass]
    public class DivideOperator_Generic : Tester
    {
        [TestMethod]
        public void Always_MultiplyWidthAndHeightTogether()
        {
            //Arrange
            var a = Fixture.Create<Size<double>>();
            var b = Fixture.Create<double>();

            //Act
            var result = a / b;

            //Assert
            result.Should().Be(new Size<double>(a.Width / b, a.Height / b));
        }
    }

    [TestClass]
    public class GreaterThanOperator : Tester
    {
        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 8);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenThisIsLargerButShorterThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 12);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenThisIsThinnerButTallerThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(11, 8);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenThisIsSmallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(7, 6);
            var b = new Size<int>(8, 8);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(10, 10);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class GreaterThanOrEqualToOperator : Tester
    {
        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 8);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenThisIsLargerButShorterThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 12);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenThisIsThinnerButTallerThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(11, 8);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenThisIsSmallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(7, 6);
            var b = new Size<int>(8, 8);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(10, 10);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class LesserThanOperator : Tester
    {
        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 8);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenThisIsLargerButShorterThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 12);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenThisIsThinnerButTallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(11, 8);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenThisIsSmallerThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(7, 6);
            var b = new Size<int>(8, 8);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(10, 10);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class LesserThanOrEqualToOperator : Tester
    {
        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 8);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenThisIsLargerButShorterThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(8, 12);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenThisIsThinnerButTallerThanOther_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(11, 8);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenThisIsSmallerThanOther_ReturnTrue()
        {
            //Arrange
            var a = new Size<int>(7, 6);
            var b = new Size<int>(8, 8);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBothAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Size<int>(10, 10);
            var b = new Size<int>(10, 10);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class ToStringMethod : Tester
    {
        [TestMethod]
        public void Always_ReturnValues()
        {
            //Arrange
            var instance = Fixture.Create<Size<float>>();

            //Act
            var result = instance.ToString();

            //Assert
            result.Should().Be($"{instance.Width}x{instance.Height}");
        }
    }

    [TestClass]
    public class Size3DOperator : Tester
    {
        [TestMethod]
        public void Always_ConvertToSize3D()
        {
            //Arrange
            var instance = Fixture.Create<Size<float>>();

            //Act
            Size3D<float> result = instance;

            //Assert
            result.Should().BeEquivalentTo(new Size3D<float> { Length = instance.Width, Width = instance.Height });
        }
    }
}