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
            var value = Dummy.Number.Between<byte>(0, (byte)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<short>(sbyte.MinValue, (short)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<ushort>(0, (ushort)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<int>(sbyte.MinValue, (int)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<uint>(0, (uint)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<long>(sbyte.MinValue, (long)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<ulong>(0, (ulong)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<float>(sbyte.MinValue, (float)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<double>(sbyte.MinValue, (double)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<decimal>(sbyte.MinValue, (decimal)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<sbyte>(0, (sbyte)sbyte.MaxValue).Create();

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
            var value = Dummy.Number.Between<short>(byte.MinValue, byte.MaxValue).Create();

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
            var value = Dummy.Number.Between<ushort>(0, ushort.MaxValue).Create();

            //Act
            var result = value.ToByteOrClamp();

            //Assert
            result.Should().Be(byte.CreateSaturating(value));
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
            var value = Dummy.Number.Between<int>(byte.MinValue, byte.MaxValue).Create();

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
            var value = Dummy.Number.Between<uint>(0, byte.MaxValue).Create();

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
            var value = Dummy.Number.Between<long>(byte.MinValue, byte.MaxValue).Create();

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
            var value = Dummy.Number.Between<ulong>(0, byte.MaxValue).Create();

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
            var value = Dummy.Number.Between<float>(byte.MinValue, byte.MaxValue).Create();

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
            var value = Dummy.Number.Between<double>(byte.MinValue, byte.MaxValue).Create();

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
            var value = Dummy.Number.Between<decimal>(byte.MinValue, byte.MaxValue).Create();

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

    [TestClass]
    public class Clamp : Tester
    {
        [TestMethod]
        public void WhenMinIsGreaterThanMax_Throw()
        {
            //Arrange
            var value = Dummy.Create<float>();
            var min = Dummy.Create<float>();
            var max = min - 1;

            //Act
            var action = () => value.Clamp(min, max);

            //Assert
            action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.MaximumValueMustBeGreaterThanMinimum, max, min));
        }

        [TestMethod]
        public void WhenValueIsLessThanMin_ReturnMin()
        {
            //Arrange
            var min = Dummy.Create<float>();
            var value = min - 1;
            var max = min + 2;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(min);
        }

        [TestMethod]
        public void WhenValueIsEqualToMin_ReturnMin()
        {
            //Arrange
            var min = Dummy.Create<float>();
            var value = min;
            var max = min + 2;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(min);
        }

        [TestMethod]
        public void WhenValueIsGreaterThanMax_ReturnMax()
        {
            //Arrange
            var min = Dummy.Create<float>();
            var max = min + 2;
            var value = max + 1;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(max);
        }

        [TestMethod]
        public void WhenValueIsEqualToMax_ReturnMax()
        {
            //Arrange
            var min = Dummy.Create<float>();
            var max = min + 2;
            var value = max;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(max);
        }

        [TestMethod]
        public void WhenValueIsBetweenMinAndMax_ReturnValue()
        {
            //Arrange
            var min = Dummy.Create<float>();
            var value = min + 1;
            var max = min + 2;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(value);
        }
    }

    [TestClass]
    public class ClampNullable : Tester
    {
        [TestMethod]
        public void WhenValueIsNull_ReturnNull()
        {
            //Arrange
            float? value = null!;
            var min = Dummy.Create<float>();
            var max = min - 1;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().BeNull();
        }

        [TestMethod]
        public void WhenMinIsGreaterThanMax_Throw()
        {
            //Arrange
            var value = Dummy.Create<float?>();
            var min = Dummy.Create<float>();
            var max = min - 1;

            //Act
            var action = () => value.Clamp(min, max);

            //Assert
            action.Should().Throw<ArgumentException>().WithMessage(string.Format(Exceptions.MaximumValueMustBeGreaterThanMinimum, max, min));
        }

        [TestMethod]
        public void WhenValueIsLessThanMin_ReturnMin()
        {
            //Arrange
            var min = Dummy.Create<float>();
            float? value = min - 1;
            var max = min + 2;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(min);
        }

        [TestMethod]
        public void WhenValueIsEqualToMin_ReturnMin()
        {
            //Arrange
            var min = Dummy.Create<float>();
            float? value = min;
            var max = min + 2;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(min);
        }

        [TestMethod]
        public void WhenValueIsGreaterThanMax_ReturnMax()
        {
            //Arrange
            var min = Dummy.Create<float>();
            var max = min + 2;
            float? value = max + 1;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(max);
        }

        [TestMethod]
        public void WhenValueIsEqualToMax_ReturnMax()
        {
            //Arrange
            var min = Dummy.Create<float>();
            var max = min + 2;
            float? value = max;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(max);
        }

        [TestMethod]
        public void WhenValueIsBetweenMinAndMax_ReturnValue()
        {
            //Arrange
            var min = Dummy.Create<float>();
            float? value = min + 1;
            var max = min + 2;

            //Act
            var result = value.Clamp(min, max);

            //Assert
            result.Should().Be(value);
        }
    }
}