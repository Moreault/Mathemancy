using System.Numerics;
using WhiteJackalStudio.TestTools;

namespace Mathemancy.Interpolation.Tests;

[TestClass]
public class InterpolatorOfFloatTests : InterpolatorTester<float>;

[TestClass]
public class InterpolatorOfDoubleTests : InterpolatorTester<double>;

[TestClass]
public class InterpolatorOfDecimalTests : InterpolatorTester<decimal>;

[TestClass]
public abstract class InterpolatorTester<T> : Tester where T : IFloatingPoint<T>, IMinMaxValue<T>
{
    [TestMethod]
    public void Interpolate_WhenProgress100_ReturnTargetValue()
    {
        //Arrange
        var start = T.CreateSaturating(100);
        var target = T.CreateSaturating(200);
        var progress = T.One;

        //Act
        var result = Interpolator.Calculate(start, target, progress);

        //Assert
        result.Should().Be(target);
    }

    [TestMethod]
    public void Interpolate_WhenBytesAtProgress50_Return150()
    {
        //Arrange
        var start = T.CreateSaturating(100);
        var target = T.CreateSaturating(200);
        var progress = T.CreateSaturating(0.5f);

        //Act
        var result = Interpolator.Calculate(start, target, progress);

        //Assert
        result.Should().Be(T.CreateSaturating(150));
    }

    [TestMethod]
    public void Interpolate_Always_Interpolate()
    {
        //Arrange
        var start = Dummy.Create<T>();
        var target = Dummy.Create<T>();
        var progress = Dummy.Number.Between(T.Zero, T.One).Create();

        //Act
        var result = Interpolator.Calculate(start, target, progress);

        //Assert
        result.Should().Be(start + (target - start) * progress);
    }

    [TestMethod]
    public void Interpolate_WhenProgressIsZero_ReturnStart()
    {
        //Arrange
        var start = Dummy.Create<T>();
        var target = Dummy.Create<T>();
        var progress = T.Zero;

        //Act
        var result = Interpolator.Calculate(start, target, progress);

        //Assert
        result.Should().Be(start);
    }

    [TestMethod]
    public void Interpolate_WhenProgressIsNegative_ReturnStart()
    {
        //Arrange
        var start = Dummy.Create<T>();
        var target = Dummy.Create<T>();
        var progress = -Dummy.Create<T>();

        //Act
        var result = Interpolator.Calculate(start, target, progress);

        //Assert
        result.Should().Be(start);
    }

    [TestMethod]
    public void Interpolate_WhenProgressIsGreaterThanOne_ReturnTarget()
    {
        //Arrange
        var start = T.Round(Dummy.Create<T>(), 0);
        var target = T.Round(Dummy.Create<T>(), 0);
        var progress = Dummy.Create<T>();

        //Act
        var result = Interpolator.Calculate(start, target, progress);

        //Assert
        result.Should().Be(target);
    }
}