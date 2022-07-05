namespace Mathemancy.Tests;

[TestClass]
public class RectangleTester
{
    [TestClass]
    public class Empty : Tester
    {
        [TestMethod]
        public void Always_ReturnDefault()
        {
            //Arrange

            //Act
            var result = Rectangle<double>.Empty;

            //Assert
            result.Should().Be(default);
        }
    }

    [TestClass]
    public class X : Tester
    {
        [TestMethod]
        public void Always_ReturnPositionInX()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<int>>();

            //Act
            var result = instance.X;

            //Assert
            result.Should().Be(instance.Position.X);
        }
    }

    [TestClass]
    public class Y : Tester
    {
        [TestMethod]
        public void Always_ReturnPositionInY()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<uint>>();

            //Act
            var result = instance.Y;

            //Assert
            result.Should().Be(instance.Position.Y);
        }
    }

    [TestClass]
    public class Width : Tester
    {
        [TestMethod]
        public void Always_ReturnWidthFromSize()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<float>>();

            //Act
            var result = instance.Width;

            //Assert
            result.Should().Be(instance.Size.Width);
        }
    }

    [TestClass]
    public class Height : Tester
    {
        [TestMethod]
        public void Always_ReturnHeightFromSize()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<ulong>>();

            //Act
            var result = instance.Height;

            //Assert
            result.Should().Be(instance.Size.Height);
        }
    }

    [TestClass]
    public class Left : Tester
    {
        [TestMethod]
        public void Always_ReturnLeftSidePosition()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<long>>();

            //Act
            var result = instance.Left;

            //Assert
            result.Should().Be(instance.Position.X);
        }
    }

    [TestClass]
    public class Right : Tester
    {
        [TestMethod]
        public void Always_ReturnRightSidePosition()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<decimal>>();

            //Act
            var result = instance.Right;

            //Assert
            result.Should().Be(instance.X + instance.Width);
        }
    }

    [TestClass]
    public class Top : Tester
    {
        [TestMethod]
        public void Always_ReturnTopSidePosition()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<double>>();

            //Act
            var result = instance.Top;

            //Assert
            result.Should().Be(instance.Y);
        }
    }

    [TestClass]
    public class Bottom : Tester
    {
        [TestMethod]
        public void Always_ReturnBottomSidePosition()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<int>>();

            //Act
            var result = instance.Bottom;

            //Assert
            result.Should().Be(instance.Y + instance.Height);
        }
    }

    [TestClass]
    public class TopLeft : Tester
    {
        [TestMethod]
        public void Always_ReturnTopLeftCoordinates()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<float>>();

            //Act
            var result = instance.TopLeft;

            //Assert
            result.Should().Be(instance.Position);
        }
    }

    [TestClass]
    public class TopRight : Tester
    {
        [TestMethod]
        public void Always_ReturnTopRightCoordinates()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<decimal>>();

            //Act
            var result = instance.TopRight;

            //Assert
            result.Should().Be(new Vector2<decimal>(instance.X + instance.Width, instance.Y));
        }
    }

    [TestClass]
    public class BottomLeft : Tester
    {
        [TestMethod]
        public void Always_ReturnBottomLeftCoordinates()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<int>>();

            //Act
            var result = instance.BottomLeft;

            //Assert
            result.Should().Be(new Vector2<int>(instance.X, instance.Y + instance.Height));
        }
    }

    [TestClass]
    public class BottomRight : Tester
    {
        [TestMethod]
        public void Always_ReturnBottomRightCoordinates()
        {
            //Arrange
            var instance = Fixture.Create<Rectangle<int>>();

            //Act
            var result = instance.BottomRight;

            //Assert
            result.Should().Be(new Vector2<int>(instance.X + instance.Width, instance.Y + instance.Height));
        }
    }

    [TestClass]
    public class Constructors : Tester
    {
        [TestMethod]
        public void WhenUsingVectorAndSize_SetValues()
        {
            //Arrange
            var vector = Fixture.Create<Vector2<float>>();
            var size = Fixture.Create<Size<float>>();

            //Act
            var result = new Rectangle<float>(vector, size);

            //Assert
            result.X.Should().Be(vector.X);
            result.Y.Should().Be(vector.Y);
            result.Width.Should().Be(size.Width);
            result.Height.Should().Be(size.Height);
        }

        [TestMethod]
        public void WhenUsingXYWidthHeight_SetValues()
        {
            //Arrange
            var x = Fixture.Create<int>();
            var y = Fixture.Create<int>();
            var width = Fixture.Create<int>();
            var height = Fixture.Create<int>();

            //Act
            var result = new Rectangle<int>(x, y, width, height);

            //Assert
            result.X.Should().Be(x);
            result.Y.Should().Be(y);
            result.Width.Should().Be(width);
            result.Height.Should().Be(height);
        }

        [TestMethod]
        public void WhenUsingVectorWidthHeight_SetValues()
        {
            //Arrange
            var vector = Fixture.Create<Vector2<decimal>>();
            var width = Fixture.Create<decimal>();
            var height = Fixture.Create<decimal>();

            //Act
            var result = new Rectangle<decimal>(vector, width, height);

            //Assert
            result.X.Should().Be(vector.X);
            result.Y.Should().Be(vector.Y);
            result.Width.Should().Be(width);
            result.Height.Should().Be(height);
        }

        [TestMethod]
        public void WhenUsingXYSize_SetValues()
        {
            //Arrange
            var x = Fixture.Create<long>();
            var y = Fixture.Create<long>();
            var size = Fixture.Create<Size<long>>();

            //Act
            var result = new Rectangle<long>(x, y, size);

            //Assert
            result.X.Should().Be(x);
            result.Y.Should().Be(y);
            result.Width.Should().Be(size.Width);
            result.Height.Should().Be(size.Height);
        }
    }

    [TestClass]
    public class CompareTo_Rectangle : Tester
    {
        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            var other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 20.5));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsLargerButShorterThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            var other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 25));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsThinnerButTallerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            var other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsBiggerThanThis_ReturnMinusOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 20.5));
            var other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(-1);
        }

        [TestMethod]
        public void WhenOtherIsLargerButShorterThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 25));
            var other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsThinnerButTallerThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));
            var other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenBothAreEqualInSize_ReturnZero()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));
            var other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));

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
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
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
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            object other = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(14, 21));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void WhenOtherIsNotRectangle_ReturnZero()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            object other = Fixture.Create<string>();

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void WhenThisIsBiggerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            object other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 20.5));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsLargerButShorterThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            object other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 25));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenThisIsThinnerButTallerThanOther_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));
            object other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsBiggerThanThis_ReturnMinusOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 20.5));
            object other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(-1);
        }

        [TestMethod]
        public void WhenOtherIsLargerButShorterThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(13.9, 25));
            object other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenOtherIsThinnerButTallerThanThis_ReturnOne()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));
            object other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(14, 21));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void WhenBothAreEqualInSize_ReturnZero()
        {
            //Arrange
            var instance = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));
            object other = new Rectangle<double>(Fixture.Create<Vector2<double>>(), new Size<double>(15, 20.5));

            //Act
            var result = instance.CompareTo(other);

            //Assert
            result.Should().Be(0);
        }
    }

    [TestClass]
    public class GreaterThanOperator_Rectangle : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 10));

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 25));

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 25));

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 10));

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class GreaterThanOrEqualToOperator_Rectangle : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 10));

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 25));

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 25));

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 10));

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class LesserThanOperator_Rectangle : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 10));

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 25));

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 25));

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 10));

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class LesserThanOrEqualToOperator_Rectangle : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 10));

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 25));

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(10, 25));

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(25, 10));

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class GreaterThanOperator_Size : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 10);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 25);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(20, 20);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 25);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 10);

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class GreaterThanOrEqualToOperator_Size : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 10);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 25);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(20, 20);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 25);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 10);

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class LesserThanOperator_Size : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 10);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 25);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(20, 20);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 25);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 10);

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class LesserThanOrEqualToOperator_Size : Tester
    {
        [TestMethod]
        public void WhenAIsBiggerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 10);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsSmallerThanB_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 25);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAAndBHaveSameSize_ReturnTrue()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(20, 20);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsWiderButShorterThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(10, 25);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsThinnerButTallerThanB_ReturnFalse()
        {
            //Arrange
            var a = new Rectangle<float>(Fixture.Create<Vector2<float>>(), new Size<float>(20, 20));
            var b = new Size<float>(25, 10);

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class ToStringMethod : Tester
    {
        [TestMethod]
        public void Always_ReturnValues()
        {
            //Arrange
            var rectangle = Fixture.Create<Rectangle<double>>();

            //Act
            var result = rectangle.ToString();

            //Assert
            result.Should().Be($"X: {rectangle.X}, Y: {rectangle.Y}, Width: {rectangle.Width}, Height: {rectangle.Height}");
        }
    }

    [TestClass]
    public class FromCoordinates : Tester
    {
        [TestMethod]
        public void WhenPoint1And2AreEqual_ReturnRectangleWithSizeZero()
        {
            //Arrange
            var point1 = Fixture.Create<Vector2<float>>();
            var point2 = point1;

            //Act
            var result = Rectangle<float>.FromCoordinates(point1, point2);

            //Assert
            result.Should().BeEquivalentTo(new Rectangle<float>(point1, new Size<float>()));
        }

        [TestMethod]
        public void WhenPoint1IsSmallerThanPoint2_Convert()
        {
            //Arrange
            var point1 = new Vector2<float>(5, 8);
            var point2 = new Vector2<float>(8, 12);

            //Act
            var result = Rectangle<float>.FromCoordinates(point1, point2);

            //Assert
            result.Should().BeEquivalentTo(new Rectangle<float>(5, 8, 3, 4));
        }

        [TestMethod]
        public void WhenPoint2IsSmallerThanPoint1_Convert()
        {
            //Arrange
            var point1 = new Vector2<float>(8, 12);
            var point2 = new Vector2<float>(5, 8);

            //Act
            var result = Rectangle<float>.FromCoordinates(point1, point2);

            //Assert
            result.Should().BeEquivalentTo(new Rectangle<float>(5, 8, 3, 4));
        }

        [TestMethod]
        public void WhenPoint1XIsSmallerThanPoint2XButPoint1YAndPoint2YEqual_Convert()
        {
            //Arrange
            var point1 = new Vector2<float>(5, 8);
            var point2 = new Vector2<float>(10, 8);

            //Act
            var result = Rectangle<float>.FromCoordinates(point1, point2);

            //Assert
            result.Should().BeEquivalentTo(new Rectangle<float>(5, 8, 5, 0));
        }

        [TestMethod]
        public void WhenPoint1XIsSmallerThanPoint2XButPoint1YIsBiggerThanPoint2Y_Convert()
        {
            //Arrange
            var point1 = new Vector2<float>(5, 12);
            var point2 = new Vector2<float>(10, 8);

            //Act
            var result = Rectangle<float>.FromCoordinates(point1, point2);

            //Assert
            result.Should().BeEquivalentTo(new Rectangle<float>(5, 8, 5, 4));
        }

        [TestMethod]
        public void WhenPoint1XIsGreaterThanPoint2XAndPoint1YIsSmallerThanPoint2Y_Convert()
        {
            //Arrange
            var point1 = new Vector2<float>(10, 8);
            var point2 = new Vector2<float>(5, 12);

            //Act
            var result = Rectangle<float>.FromCoordinates(point1, point2);

            //Assert
            result.Should().BeEquivalentTo(new Rectangle<float>(5, 8, 5, 4));
        }

        [TestMethod]
        public void WhenPoint1XIsGreaterThanPoint2XAndPoint1YIsGreaterThanPoint2Y_Convert()
        {
            //Arrange
            var point1 = new Vector2<float>(10, 12);
            var point2 = new Vector2<float>(5, 8);

            //Act
            var result = Rectangle<float>.FromCoordinates(point1, point2);

            //Assert
            result.Should().BeEquivalentTo(new Rectangle<float>(5, 8, 5, 4));
        }
    }
}