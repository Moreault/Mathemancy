namespace Mathemancy.Tests;

[TestClass]
public class DistanceTester
{
    [TestClass]
    public class Calculate : TestBase
    {
        [TestMethod]
        public void WhenStraightHorizontalLine_ReturnDistanceBetweenTwoVectors()
        {
            //Arrange
            var a = new Vector2<float>(2, 2);
            var b = new Vector2<float>(4, 2);

            //Act
            var result = Distance.Calculate(a, b);

            //Assert
            result.Should().Be(2);
        }

        [TestMethod]
        public void WhenReversedStraightHorizontalLine_ReturnDistanceBetweenTwoVectors()
        {
            //Arrange
            var a = new Vector2<float>(4, 2);
            var b = new Vector2<float>(2, 2);

            //Act
            var result = Distance.Calculate(a, b);

            //Assert
            result.Should().Be(2);
        }

        [TestMethod]
        public void WhenStraightVerticalLine_ReturnDistance()
        {
            //Arrange
            var a = new Vector2<float>(2, 2);
            var b = new Vector2<float>(2, 4);

            //Act
            var result = Distance.Calculate(a, b);

            //Assert
            result.Should().Be(2);
        }
    }
}