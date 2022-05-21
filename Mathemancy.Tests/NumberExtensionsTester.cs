namespace Mathemancy.Tests;

[TestClass]
public class NumberExtensionsTester
{
    [TestClass]
    public class ToSByteOrClamp : Tester
    {
        //TODO Test
        [TestMethod]
        public void WhenIsByteAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = byte.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsByteAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (byte)Fixture.CreateBetween(0, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsShortAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = short.MinValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MinValue);
        }

        [TestMethod]
        public void WhenIsShortAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = short.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsShortAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (short)Fixture.CreateBetween(sbyte.MinValue, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsUShortAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = ushort.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsUShortAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (ushort)Fixture.CreateBetween(0, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsIntAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = int.MinValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MinValue);
        }

        [TestMethod]
        public void WhenIsIntAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = int.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsIntAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (int)Fixture.CreateBetween(sbyte.MinValue, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsUIntAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = uint.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsUIntAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (uint)Fixture.CreateBetween(0, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsLongAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = long.MinValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MinValue);
        }

        [TestMethod]
        public void WhenIsLongAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = long.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsLongAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (long)Fixture.CreateBetween(sbyte.MinValue, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsULongAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = ulong.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsULongAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (ulong)Fixture.CreateBetween(0, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsFloatAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = float.MinValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MinValue);
        }

        [TestMethod]
        public void WhenIsFloatAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = float.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsFloatAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (float)Fixture.CreateBetween(sbyte.MinValue, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsDoubleAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = double.MinValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MinValue);
        }

        [TestMethod]
        public void WhenIsDoubleAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = double.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsDoubleAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (double)Fixture.CreateBetween(sbyte.MinValue, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }

        [TestMethod]
        public void WhenIsDecimalAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = decimal.MinValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MinValue);
        }

        [TestMethod]
        public void WhenIsDecimalAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = decimal.MaxValue;

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be(sbyte.MaxValue);
        }

        [TestMethod]
        public void WhenIsDecimalAndBetweenBoundaries_ReturnAsSByte()
        {
            //Arrange
            var value = (decimal)Fixture.CreateBetween(sbyte.MinValue, sbyte.MaxValue);

            //Act
            var result = value.ToSByteOrClamp();

            //Assert
            result.Should().Be((sbyte)value);
        }
    }

    [TestClass]
    public class ToSByteOrDefault : Tester
    {
        //TODO Test

    }

    [TestClass]
    public class ToByteOrClamp : Tester
    {
        [TestMethod]
        public void WhenIsByteAndLesserThanMinValue_ReturnMaxValue()
        {
            //Arrange
            var value = sbyte.MinValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MinValue);
        }

        [TestMethod]
        public void WhenIsSByteAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (sbyte)Fixture.CreateBetween(0, sbyte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsShortAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = short.MinValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MinValue);
        }

        [TestMethod]
        public void WhenIsShortAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = short.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsShortAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (short)Fixture.CreateBetween(byte.MinValue, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsUShortAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = ushort.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsUShortAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (ushort)Fixture.CreateBetween(0, ushort.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsIntAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = int.MinValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MinValue);
        }

        [TestMethod]
        public void WhenIsIntAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = int.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsIntAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (int)Fixture.CreateBetween(byte.MinValue, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsUIntAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = uint.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsUIntAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (uint)Fixture.CreateBetween(0, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsLongAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = long.MinValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MinValue);
        }

        [TestMethod]
        public void WhenIsLongAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = long.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsLongAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (long)Fixture.CreateBetween(byte.MinValue, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsULongAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = ulong.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsULongAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (ulong)Fixture.CreateBetween(0, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsFloatAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = float.MinValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MinValue);
        }

        [TestMethod]
        public void WhenIsFloatAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = float.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsFloatAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (float)Fixture.CreateBetween(byte.MinValue, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsDoubleAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = double.MinValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MinValue);
        }

        [TestMethod]
        public void WhenIsDoubleAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = double.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsDoubleAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (double)Fixture.CreateBetween(byte.MinValue, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }

        [TestMethod]
        public void WhenIsDecimalAndLesserThanMinValue_ReturnMinValue()
        {
            //Arrange
            var value = decimal.MinValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MinValue);
        }

        [TestMethod]
        public void WhenIsDecimalAndGreaterThanMaxValue_ReturnMaxValue()
        {
            //Arrange
            var value = decimal.MaxValue;

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.MaxValue);
        }

        [TestMethod]
        public void WhenIsDecimalAndBetweenBoundaries_ReturnAsByte()
        {
            //Arrange
            var value = (decimal)Fixture.CreateBetween(byte.MinValue, byte.MaxValue);

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be((byte)value);
        }
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
}