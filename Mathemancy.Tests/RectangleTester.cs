using System.Numerics;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ToolBX.Mathemancy.Json;

namespace Mathemancy.Tests;

[TestClass]
public class RectangleOfIntTests : RectangleTester<int>;

[TestClass]
public class RectangleOfFloatTests : RectangleTester<float>;

[TestClass]
public class RectangleOfDoubleTests : RectangleTester<double>;

[TestClass]
public class RectangleOfDecimalTests : RectangleTester<decimal>;

public abstract class RectangleTester<T> : TestBase where T : struct, INumber<T>
{
    [TestMethod]
    public void Empty_Always_ReturnDefault()
    {
        //Arrange

        //Act
        var result = Rectangle<T>.Empty;

        //Assert
        result.Should().Be(default);
    }

    [TestMethod]
    public void X_Always_ReturnPositionInX()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.X;

        //Assert
        result.Should().Be(instance.Position.X);
    }

    [TestMethod]
    public void Y_Always_ReturnPositionInY()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.Y;

        //Assert
        result.Should().Be(instance.Position.Y);
    }

    [TestMethod]
    public void Width_Always_ReturnWidthFromSize()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.Width;

        //Assert
        result.Should().Be(instance.Size.Width);
    }

    [TestMethod]
    public void Height_Always_ReturnHeightFromSize()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.Height;

        //Assert
        result.Should().Be(instance.Size.Height);
    }

    [TestMethod]
    public void Left_Always_ReturnLeftSidePosition()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.Left;

        //Assert
        result.Should().Be(instance.Position.X);
    }

    [TestMethod]
    public void Right_Always_ReturnRightSidePosition()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.Right;

        //Assert
        result.Should().Be(instance.X + instance.Width);
    }

    [TestMethod]
    public void Top_Always_ReturnTopSidePosition()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.Top;

        //Assert
        result.Should().Be(instance.Y);
    }

    [TestMethod]
    public void Bottom_Always_ReturnBottomSidePosition()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.Bottom;

        //Assert
        result.Should().Be(instance.Y + instance.Height);
    }

    [TestMethod]
    public void TopLeft_Always_ReturnTopLeftCoordinates()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.TopLeft;

        //Assert
        result.Should().Be(instance.Position);
    }

    [TestMethod]
    public void TopRight_Always_ReturnTopRightCoordinates()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.TopRight;

        //Assert
        result.Should().Be(new Vector2<T>(instance.X + instance.Width, instance.Y));
    }

    [TestMethod]
    public void BottomLeft_Always_ReturnBottomLeftCoordinates()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.BottomLeft;

        //Assert
        result.Should().Be(new Vector2<T>(instance.X, instance.Y + instance.Height));
    }

    [TestMethod]
    public void BottomRight_Always_ReturnBottomRightCoordinates()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();

        //Act
        var result = instance.BottomRight;

        //Assert
        result.Should().Be(new Vector2<T>(instance.X + instance.Width, instance.Y + instance.Height));
    }

    [TestMethod]
    public void Constructor_WhenUsingVectorAndSize_SetValues()
    {
        //Arrange
        var vector = Dummy.Create<Vector2<T>>();
        var size = Dummy.Create<Size<T>>();

        //Act
        var result = new Rectangle<T>(vector, size);

        //Assert
        result.X.Should().Be(vector.X);
        result.Y.Should().Be(vector.Y);
        result.Width.Should().Be(size.Width);
        result.Height.Should().Be(size.Height);
    }

    [TestMethod]
    public void Constructor_WhenUsingXYWidthHeight_SetValues()
    {
        //Arrange
        var x = Dummy.Create<T>();
        var y = Dummy.Create<T>();
        var width = Dummy.Create<T>();
        var height = Dummy.Create<T>();

        //Act
        var result = new Rectangle<T>(x, y, width, height);

        //Assert
        result.X.Should().Be(x);
        result.Y.Should().Be(y);
        result.Width.Should().Be(width);
        result.Height.Should().Be(height);
    }

    [TestMethod]
    public void Constructor_WhenUsingVectorWidthHeight_SetValues()
    {
        //Arrange
        var vector = Dummy.Create<Vector2<T>>();
        var width = Dummy.Create<T>();
        var height = Dummy.Create<T>();

        //Act
        var result = new Rectangle<T>(vector, width, height);

        //Assert
        result.X.Should().Be(vector.X);
        result.Y.Should().Be(vector.Y);
        result.Width.Should().Be(width);
        result.Height.Should().Be(height);
    }

    [TestMethod]
    public void Constructor_WhenUsingXYSize_SetValues()
    {
        //Arrange
        var x = Dummy.Create<T>();
        var y = Dummy.Create<T>();
        var size = Dummy.Create<Size<T>>();

        //Act
        var result = new Rectangle<T>(x, y, size);

        //Assert
        result.X.Should().Be(x);
        result.Y.Should().Be(y);
        result.Width.Should().Be(size.Width);
        result.Height.Should().Be(size.Height);
    }

    [TestMethod]
    public void CompareToRectangle_WhenThisIsBiggerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        var other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(20.5)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToRectangle_WhenThisIsLargerButShorterThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        var other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(25)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToRectangle_WhenThisIsThinnerButTallerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        var other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToRectangle_WhenOtherIsBiggerThanThis_ReturnMinusOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(20.5)));
        var other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(-1);
    }

    [TestMethod]
    public void CompareToRectangle_WhenOtherIsLargerButShorterThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(25)));
        var other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToRectangle_WhenOtherIsThinnerButTallerThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));
        var other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToRectangle_WhenBothAreEqualInSize_ReturnZero()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));
        var other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsNull_ReturnZero()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
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
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsNotRectangle_ReturnZero()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        object other = Dummy.Create<string>();

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void CompareToObject_WhenThisIsBiggerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(20.5)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenThisIsLargerButShorterThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(25)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenThisIsThinnerButTallerThanOther_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsBiggerThanThis_ReturnMinusOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(20.5)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(-1);
    }

    [TestMethod]
    public void CompareToObject_WhenOtherIsLargerButShorterThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(13.9), T.CreateSaturating(25)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void WhenOtherIsThinnerButTallerThanThis_ReturnOne()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(14), T.CreateSaturating(21)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CompareToObject_WhenBothAreEqualInSize_ReturnZero()
    {
        //Arrange
        var instance = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));
        object other = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(15), T.CreateSaturating(20.5)));

        //Act
        var result = instance.CompareTo(other);

        //Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void GreaterThanOperatorRectangle_WhenAIsBiggerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10)));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOperatorRectangle_WhenAIsSmallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25)));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOperatorRectangle_WhenAAndBHaveSameSize_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOperatorRectangle_WhenAIsWiderButShorterThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25)));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOperatorRectangle_WhenAIsThinnerButTallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10)));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorRectangle_WhenAIsBiggerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10)));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorRectangle_WhenAIsSmallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25)));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorRectangle_WhenAAndBHaveSameSize_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorRectangle_WhenAIsWiderButShorterThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25)));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorRectangle_WhenAIsThinnerButTallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10)));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOperatorRectangle_WhenAIsBiggerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10)));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperatorRectangle_WhenAIsSmallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25)));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOperatorRectangle_WhenAAndBHaveSameSize_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperatorRectangle_WhenAIsWiderButShorterThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25)));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperatorRectangle_WhenAIsThinnerButTallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10)));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorRectangle_WhenAIsBiggerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10)));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorRectangle_WhenAIsSmallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25)));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorRectangle_WhenAAndBHaveSameSize_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorRectangle_WhenAIsWiderButShorterThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25)));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorRectangle_WhenAIsThinnerButTallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10)));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOperatorSize_WhenAIsBiggerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOperatorSize_WhenAIsSmallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOperatorSize_WhenAAndBHaveSameSize_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOperatorSize_WhenAIsWiderButShorterThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOperatorSize_WhenAIsThinnerButTallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10));

        //Act
        var result = a > b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorSize_WhenAIsBiggerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorSize_WhenAIsSmallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorSize_WhenAAndBHaveSameSize_ReturTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorSize_WhenAIsWiderButShorterThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void GreaterThanOrEqualToOperatorSize_WhenAIsThinnerButTallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10));

        //Act
        var result = a >= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOperatorSize_WhenAIsBiggerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperatorSize_WhenAIsSmallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOperatorSize_WhenAAndBHaveSameSize_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperatorSize_WhenAIsWiderButShorterThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOperatorSize_WhenAIsThinnerButTallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10));

        //Act
        var result = a < b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorSize_WhenAIsBiggerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(10));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorSize_WhenAIsSmallerThanB_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(25));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorSize_WhenAAndBHaveSameSize_ReturnTrue()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorSize_WhenAIsWiderButShorterThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(10), T.CreateSaturating(25));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void LesserThanOrEqualToOperatorSize_WhenAIsThinnerButTallerThanB_ReturnFalse()
    {
        //Arrange
        var a = new Rectangle<T>(Dummy.Create<Vector2<T>>(), new Size<T>(T.CreateSaturating(20), T.CreateSaturating(20)));
        var b = new Size<T>(T.CreateSaturating(25), T.CreateSaturating(10));

        //Act
        var result = a <= b;

        //Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void ToString_Always_ReturnValues()
    {
        //Arrange
        var rectangle = Dummy.Create<Rectangle<double>>();

        //Act
        var result = rectangle.ToString();

        //Assert
        result.Should().Be($"({rectangle.X}, {rectangle.Y}) {rectangle.Width}x{rectangle.Height}");
    }

    [TestMethod]
    public void FromCoordinates_WhenPoint1And2AreEqual_ReturnRectangleWithSizeZero()
    {
        //Arrange
        var point1 = Dummy.Create<Vector2<float>>();
        var point2 = point1;

        //Act
        var result = Rectangle<float>.FromCoordinates(point1, point2);

        //Assert
        result.Should().BeEquivalentTo(new Rectangle<float>(point1, new Size<float>()));
    }

    [TestMethod]
    public void FromCoordinates_WhenPoint1IsSmallerThanPoint2_Convert()
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
    public void FromCoordinates_WhenPoint2IsSmallerThanPoint1_Convert()
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
    public void FromCoordinates_WhenPoint1XIsSmallerThanPoint2XButPoint1YAndPoint2YEqual_Convert()
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
    public void FromCoordinates_WhenPoint1XIsSmallerThanPoint2XButPoint1YIsBiggerThanPoint2Y_Convert()
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
    public void FromCoordinates_WhenPoint1XIsGreaterThanPoint2XAndPoint1YIsSmallerThanPoint2Y_Convert()
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
    public void FromCoordinates_WhenPoint1XIsGreaterThanPoint2XAndPoint1YIsGreaterThanPoint2Y_Convert()
    {
        //Arrange
        var point1 = new Vector2<float>(10, 12);
        var point2 = new Vector2<float>(5, 8);

        //Act
        var result = Rectangle<float>.FromCoordinates(point1, point2);

        //Assert
        result.Should().BeEquivalentTo(new Rectangle<float>(5, 8, 5, 4));
    }

    [TestMethod]
    public void JsonSerialization_WhenSerializedWithDefaultAndDeserializedWithCustom_ConvertProperly()
    {
        //Arrange
        var instance = Dummy.Create<Rectangle<T>>();
        var json = JsonSerializer.Serialize(instance);

        //Act
        var result = JsonSerializer.Deserialize<Rectangle<T>>(json, JsonSerializerOptions.WithMathemancyConverters());

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    [DataRow(false, false)]
    [DataRow(true, false)]
    [DataRow(false, true)]
    [DataRow(true, true)]
    public void JsonSerialization_WhenHasNegativeValues_ConvertProperly(bool isNegativeX, bool isNegativeY)
    {
        //Arrange
        var instance = new Rectangle<T>
        {
            Position = new Vector2<T>((isNegativeX ? T.CreateSaturating(-1) : T.CreateSaturating(1)) * Dummy.Create<T>(), (isNegativeY ? T.CreateSaturating(-1) : T.CreateSaturating(1)) * Dummy.Create<T>()),
            Size = Dummy.Create<Size<T>>()
        };

        var json = JsonSerializer.Serialize(instance, JsonSerializerOptions.WithMathemancyConverters());

        //Act
        var result = JsonSerializer.Deserialize<Rectangle<T>>(json, JsonSerializerOptions);

        //Assert
        result.Should().BeEquivalentTo(instance);
    }

    [TestMethod]
    public void Ensure_ValueEquality() => Ensure.ValueEquality<Rectangle<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_ValueHashCode() => Ensure.ValueHashCode<Rectangle<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_IsJsonSerializable() => Ensure.IsJsonSerializable<Rectangle<T>>(Dummy, JsonSerializerOptions.WithMathemancyConverters());

    [TestMethod]
    public void Ensure_IsJsonSerializableByDefault() => Ensure.IsJsonSerializable<Rectangle<T>>(Dummy);
}