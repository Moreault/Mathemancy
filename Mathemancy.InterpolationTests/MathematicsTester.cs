namespace Mathemancy.Interpolation.Tests;

[TestClass]
public class InterpolatorTester
{
    [TestClass]
    public class Interpolate_Float : Tester
    {
        [TestMethod]
        public void WhenProgress100_ReturnTargetValue()
        {
            //Arrange
            var start = 100;
            var target = 200;
            float progress = 1;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }

        [TestMethod]
        public void WhenBytesAtProgress50_Return150()
        {
            //Arrange
            var start = 100;
            var target = 200;
            var progress = 0.5f;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(150);
        }

        [TestMethod]
        public void Always_Interpolate()
        {
            //Arrange
            var start = Fixture.Create<float>();
            var target = Fixture.Create<float>();
            var progress = Fixture.CreateNormalizedFloat();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start + (target - start) * progress);
        }

        [TestMethod]
        public void WhenProgressIsZero_ReturnStart()
        {
            //Arrange
            var start = Fixture.Create<float>();
            var target = Fixture.Create<float>();
            var progress = 0;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start);
        }

        [TestMethod]
        public void WhenProgressIsNegative_ReturnStart()
        {
            //Arrange
            var start = Fixture.Create<float>();
            var target = Fixture.Create<float>();
            var progress = -Fixture.Create<float>();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start);
        }

        [TestMethod]
        public void WhenProgressIsGreaterThanOne_ReturnTarget()
        {
            //Arrange
            var start = Fixture.Create<float>();
            var target = Fixture.Create<float>();
            var progress = Fixture.Create<float>();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }
    }

    [TestClass]
    public class Interpolate_Double : Tester
    {
        [TestMethod]
        public void WhenProgress100_ReturnTargetValue()
        {
            //Arrange
            var start = 100d;
            var target = 200d;
            var progress = 1d;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }

        [TestMethod]
        public void WhenBytesAtProgress50_Return150()
        {
            //Arrange
            var start = 100d;
            var target = 200d;
            var progress = 0.5d;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(150);
        }

        [TestMethod]
        public void Always_Interpolate()
        {
            //Arrange
            var start = Fixture.Create<double>();
            var target = Fixture.Create<double>();
            var progress = (double)Fixture.CreateNormalizedFloat();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start + (target - start) * progress);
        }

        [TestMethod]
        public void WhenProgressIsZero_ReturnStart()
        {
            //Arrange
            var start = Fixture.Create<double>();
            var target = Fixture.Create<double>();
            var progress = 0;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start);
        }

        [TestMethod]
        public void WhenProgressIsNegative_ReturnStart()
        {
            //Arrange
            var start = Fixture.Create<double>();
            var target = Fixture.Create<double>();
            var progress = -Fixture.Create<double>();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start);
        }

        [TestMethod]
        public void WhenProgressIsOne_ReturnTarget()
        {
            //Arrange
            var start = Fixture.Create<double>();
            var target = Fixture.Create<double>();
            var progress = 1d;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }

        [TestMethod]
        public void WhenProgressIsGreaterThanOne_ReturnTarget()
        {
            //Arrange
            var start = Fixture.Create<double>();
            var target = Fixture.Create<double>();
            var progress = Fixture.Create<double>();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }
    }

    [TestClass]
    public class Interpolate_Decimal : Tester
    {
        [TestMethod]
        public void WhenProgress100_ReturnTargetValue()
        {
            //Arrange
            var start = 100m;
            var target = 200m;
            var progress = 1m;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }

        [TestMethod]
        public void WhenBytesAtProgress50_Return150()
        {
            //Arrange
            var start = 100m;
            var target = 200m;
            var progress = 0.5m;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(150);
        }

        [TestMethod]
        public void Always_Interpolate()
        {
            //Arrange
            var start = Fixture.Create<decimal>();
            var target = Fixture.Create<decimal>();
            var progress = (decimal)Fixture.CreateNormalizedFloat();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start + (target - start) * progress);
        }

        [TestMethod]
        public void WhenProgressIsZero_ReturnStart()
        {
            //Arrange
            var start = Fixture.Create<decimal>();
            var target = Fixture.Create<decimal>();
            var progress = 0m;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start);
        }

        [TestMethod]
        public void WhenProgressIsNegative_ReturnStart()
        {
            //Arrange
            var start = Fixture.Create<decimal>();
            var target = Fixture.Create<decimal>();
            var progress = -Fixture.Create<decimal>();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(start);
        }

        [TestMethod]
        public void WhenProgressIsOne_ReturnTarget()
        {
            //Arrange
            var start = Fixture.Create<decimal>();
            var target = Fixture.Create<decimal>();
            var progress = 1m;

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }

        [TestMethod]
        public void WhenProgressIsGreaterThanOne_ReturnTarget()
        {
            //Arrange
            var start = Fixture.Create<decimal>();
            var target = Fixture.Create<decimal>();
            var progress = Fixture.Create<decimal>();

            //Act
            var result = Interpolator.Calculate(start, target, progress);

            //Assert
            result.Should().Be(target);
        }
    }

    [TestClass]
    public class Interpolate_Vector2_Float : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class Interpolate_Vector2_Double : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class Interpolate_Vector2_Decimal : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class GetDelta : Tester
    {
        //TODO Test
    }
}