using Mathemancy.UnitTesting;

namespace Mathemancy.Randomness.Tests;

[TestClass]
public class SByteSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, sbyte>
{

}

[TestClass]
public class ByteSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, byte>
{

}

[TestClass]
public class ShortSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, short>
{

}

[TestClass]
public class UShortSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, ushort>
{

}

[TestClass]
public class IntSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, int>
{

}

[TestClass]
public class UIntSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, uint>
{

}

[TestClass]
public class LongSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, long>
{

}

[TestClass]
public class ULongSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, ulong>
{

}

[TestClass]
public class FloatSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, float>
{

}

[TestClass]
public class DoubleSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, double>
{

}

[TestClass]
public class DecimalSecureRandomNumberGeneratorTest : RandomNumberGeneratorTester<SecureRandomNumberGenerator, decimal>
{

}

[TestClass]
public class SecureRandomNumberGeneratorTest
{
    [TestClass]
    public class Generate_Int32_NoMin : TestBase<SecureRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_GenerateNumbersBetweenBoundaries()
        {
            //Arrange

            //Act
            var result = Instance.Generate(150);

            //Assert
            result.Should().BeGreaterOrEqualTo(0);
            result.Should().BeLessOrEqualTo(150);
        }
    }

    [TestClass]
    public class Generate_Int32 : TestBase<SecureRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_GenerateNumbersBetweenBoundaries()
        {
            //Arrange
            
            //Act
            var result = Instance.Generate(10, 25);

            //Assert
            result.Should().BeGreaterOrEqualTo(10);
            result.Should().BeLessOrEqualTo(25);
        }
    }

    [TestClass]
    public class Generate_Int64_NoMin : TestBase<SecureRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_GenerateNumbersBetweenBoundaries()
        {
            //Arrange

            //Act
            var result = Instance.Generate((long)int.MaxValue + 1200);

            //Assert
            result.Should().BeGreaterOrEqualTo(0);
            result.Should().BeLessOrEqualTo((long)int.MaxValue + 1200);
        }
    }

    [TestClass]
    public class Generate_Int64 : TestBase<SecureRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_GenerateNumbersBetweenBoundaries()
        {
            //Arrange

            //Act
            var result = Instance.Generate((long)int.MinValue - 200, (long)int.MaxValue + 1200);

            //Assert
            result.Should().BeGreaterOrEqualTo((long)int.MinValue - 200);
            result.Should().BeLessOrEqualTo((long)int.MaxValue + 1200);
        }
    }

    [TestClass]
    public class Generate_Double_NoMin : TestBase<SecureRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_GenerateNumbersBetweenBoundaries()
        {
            //Arrange
            var max = 28.788d;

            //Act
            var result = Instance.Generate(max);

            //Assert
            result.Should().BeGreaterOrEqualTo(0);
            result.Should().BeLessOrEqualTo(max);
        }
    }

    [TestClass]
    public class Generate_Double : TestBase<SecureRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_GenerateNumbersBetweenBoundaries()
        {
            //Arrange
            var min = -1000.567d;
            var max = 25000.788d;

            //Act
            var result = Instance.Generate(min,max );

            //Assert
            result.Should().BeGreaterOrEqualTo(min);
            result.Should().BeLessOrEqualTo(max);
        }

    }

    [TestClass]
    public class GenerateFractions : TestBase<SecureRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_OnlyReturnFractionalNumberBetweenZeroAndOneExclusively()
        {
            //Arrange

            //Act
            var result = Instance.GenerateFractions();

            //Assert
            result.Should().BeGreaterOrEqualTo(0.0d);
            result.Should().BeLessThan(1.0d);
        }
    }
}