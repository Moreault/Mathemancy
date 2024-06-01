namespace Mathemancy.Tests;

[TestClass]
public class LoopClampTest : Tester
{
    [TestMethod]
    public void WhenValueIsIntWithinRange_ReturnUnmodified()
    {
        //Arrange
        var value = Dummy.Create<int>();
        var min = value - 1;
        var max = value + 1;

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(value);
    }

    [TestMethod]
    [DataRow(0.1f, 0.0f, 1.0f)]
    [DataRow(0.33f, 0.0f, 1.0f)]
    [DataRow(-0.25f, -1.0f, 1.0f)]
    [DataRow(-0.99f, -1.0f, 1.0f)]
    [DataRow(0.74f, -1.0f, 1.0f)]
    public void WhenValueIsFloatWithinRange_ReturnUnmodified(float value, float min, float max)
    {
        //Arrange

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(value);
    }

    [TestMethod]
    [DataRow(0.1d, 0.0d, 1.0d)]
    [DataRow(0.33d, 0.0d, 1.0d)]
    [DataRow(-0.25d, -1.0d, 1.0d)]
    [DataRow(-0.99d, -1.0d, 1.0d)]
    [DataRow(0.74d, -1.0d, 1.0d)]
    public void WhenValueIsDoubleWithinRange_ReturnUnmodified(double value, double min, double max)
    {
        //Arrange

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(value);
    }

    [TestMethod]
    public void WhenValueIsDecimalWithinRange_ReturnUnmodified()
    {
        //Arrange
        var value = Dummy.Create<decimal>();
        var min = value - 1;
        var max = value + 1;

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(value);
    }

    [TestMethod]
    [DataRow(-2, 0, 10, 8)]
    [DataRow(8, 10, 20, 18)]
    public void WhenValueIsLessThanMinimum_ReturnLooped(int value, int min, int max, int expected)
    {
        //Arrange

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(14, 0, 10, 4)]
    [DataRow(28, 10, 20, 18)]
    public void WhenValueIsGreaterThanMaximum_ReturnLooped(int value, int min, int max, int expected)
    {
        //Arrange

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(-0.1f, 0, 1.0f, 0.9f)]
    [DataRow(-0.25f, 0, 1.0f, 0.75f)]
    [DataRow(-1.5f, 0, 1.0f, 0.5f)]
    public void WhenValueIsFloatAndLessThanMinimum_ReturnLooped(float value, float min, float max, float expected)
    {
        //Arrange

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(1.1f, 0, 1.0f, 0.1f)]
    [DataRow(1.25f, 0, 1.0f, 0.25f)]
    [DataRow(2.5f, 0, 1.0f, 0.5f)]
    public void WhenValueIsFloatAndGreaterThanMaximum_ReturnLooped(float value, float min, float max, float expected)
    {
        //Arrange
        var epsilon = 0.0000001f;

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().BeInRange(expected - epsilon, expected + epsilon);
    }

    [TestMethod]
    public void WhenValueIsMinimum_ReturnUnmodifiedValue()
    {
        //Arrange
        var value = Dummy.Create<float>();
        var min = value;
        var max = value + 1;

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(min);
    }

    [TestMethod]
    public void WhenValueIsMaximum_ReturnUnmodifiedValue()
    {
        //Arrange
        var value = Dummy.Create<float>();
        var min = value - 1;
        var max = value;

        //Act
        var result = value.LoopClamp(min, max);

        //Assert
        result.Should().Be(max);
    }

    [TestMethod]
    public void WhenMinIsGreaterThanMax_Throw()
    {
        //Arrange
        var value = Dummy.Create<float>();
        var min = Dummy.Create<float>();
        var max = min - 1;

        //Act
        var action = () => value.LoopClamp(min, max);

        //Assert
        action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.MaximumValueMustBeGreaterThanMinimum, max, min));
    }
}