namespace Mathemancy.Tests;

[TestClass]
public class Vector2ExtensionsTest
{
    [TestClass]
    public class ToSByteOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToSByteOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToByteOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToByteOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToShortOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToShortOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToUShortOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToUShortOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToIntOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToIntOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToUIntOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToUIntOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToLongOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToLongOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToULongOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToULongOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToFloatOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToFloatOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToDoubleOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToDoubleOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToDecimalOrClamp : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class ToDecimalOrDefault : Tester
    {
        //TODO Test
    }

    [TestClass]
    public class Normalize : Tester
    {
        private const float Epsilon = 5.96046448E-08f;

        [TestMethod]
        public void WhenIsZeroVector_ReturnZeroVector()
        {
            //Arrange

            //Act
            var result = Vector2<float>.Zero.Normalize();

            //Assert
            result.Should().Be(Vector2<float>.Zero);
        }

        [TestMethod]
        public void WhenIsUp_ReturnsZeroMinusOne()
        {
            //Arrange
            var value = new Vector2<float>(0, -Dummy.Create<float>());

            //Act
            var result = value.Normalize();

            //Assert
            var expected = new Vector2<float>(0, -1);
            result.X.Should().BeInRange(expected.X - Epsilon, expected.X + Epsilon);
            result.Y.Should().BeInRange(expected.Y - Epsilon, expected.Y + Epsilon);
        }

        [TestMethod]
        public void WhenIsRight_ReturnsOneZero()
        {
            //Arrange
            var value = new Vector2<float>(Dummy.Create<float>(), 0);

            //Act
            var result = value.Normalize();

            //Assert
            var expected = new Vector2<float>(1, 0);
            result.X.Should().BeInRange(expected.X - Epsilon, expected.X + Epsilon);
            result.Y.Should().BeInRange(expected.Y - Epsilon, expected.Y + Epsilon);
        }

        [TestMethod]
        public void WhenIsDown_ReturnsZeroOne()
        {
            //Arrange
            var value = new Vector2<float>(0, Dummy.Create<float>());

            //Act
            var result = value.Normalize();

            //Assert
            var expected = new Vector2<float>(0, 1);
            result.X.Should().BeInRange(expected.X - Epsilon, expected.X + Epsilon);
            result.Y.Should().BeInRange(expected.Y - Epsilon, expected.Y + Epsilon);
        }

        [TestMethod]
        public void WhenIsLeft_ReturnsMinusOneZero()
        {
            //Arrange
            var value = new Vector2<float>(-Dummy.Create<float>(), 0);

            //Act
            var result = value.Normalize();

            //Assert
            var expected = new Vector2<float>(-1, 0);
            result.X.Should().BeInRange(expected.X - Epsilon, expected.X + Epsilon);
            result.Y.Should().BeInRange(expected.Y - Epsilon, expected.Y + Epsilon);
        }
    }
}