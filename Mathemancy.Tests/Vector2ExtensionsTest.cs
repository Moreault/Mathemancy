using System.Numerics;
using FluentAssertions.Execution;
using FluentAssertions.Numeric;
using FluentAssertions.Primitives;
using System.Runtime.InteropServices.JavaScript;
using System.Diagnostics.Contracts;

namespace Mathemancy.Tests;

[TestClass]
public class Vector2ExtensionsTest
{
    [TestClass]
    public class ToSByteOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToSByteOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToByteOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToByteOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToShortOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToShortOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToUShortOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToUShortOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToIntOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToIntOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToUIntOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToUIntOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToLongOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToLongOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToULongOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToULongOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToFloatOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToFloatOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToDoubleOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToDoubleOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToDecimalOrClamp : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class ToDecimalOrDefault : TestBase
    {
        //TODO Test
    }

    [TestClass]
    public class Normalize : TestBase
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