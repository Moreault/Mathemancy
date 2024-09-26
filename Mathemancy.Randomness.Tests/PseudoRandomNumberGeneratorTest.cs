namespace Mathemancy.Randomness.Tests;

[TestClass]
public class SBytePseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, sbyte>;

[TestClass]
public class BytePseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, byte>;

[TestClass]
public class ShortPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, short>;

[TestClass]
public class UShortPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, ushort>;

[TestClass]
public class IntPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, int>;

[TestClass]
public class UIntPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, uint>;

[TestClass]
public class LongPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, long>;

[TestClass]
public class ULongPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, ulong>;

[TestClass]
public class FloatPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, float>;

[TestClass]
public class DoublePseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, double>;

[TestClass]
public class DecimalPseudoRandomNumberGeneratorTest : RandomNumberGeneratorTester<PseudoRandomNumberGenerator, decimal>;

[TestClass]
public class PseudoRandomNumberGeneratorTest
{
    [TestClass]
    public class Generate_Int32_NoMin : Tester<PseudoRandomNumberGenerator>
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
    public class Generate_Int32 : Tester<PseudoRandomNumberGenerator>
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
    public class Generate_Int64_NoMin : Tester<PseudoRandomNumberGenerator>
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
    public class Generate_Int64 : Tester<PseudoRandomNumberGenerator>
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
    public class Generate_Double_NoMin : Tester<PseudoRandomNumberGenerator>
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
    public class Generate_Double : Tester<PseudoRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_GenerateNumbersBetweenBoundaries()
        {
            //Arrange
            var min = -1000.567d;
            var max = 25000.788d;

            //Act
            var result = Instance.Generate(min, max);

            //Assert
            result.Should().BeGreaterOrEqualTo(min);
            result.Should().BeLessOrEqualTo(max);
        }
    }

    [TestClass]
    public class GenerateFractions : Tester<PseudoRandomNumberGenerator>
    {
        [TestMethod]
        public void Always_OnlyReturnFractionalNumberBetweenZeroAndOneExclusively()
        {
            //Arrange

            //Act
            var result = Instance.GenerateFractions<double>();

            //Assert
            result.Should().BeGreaterOrEqualTo(0.0d);
            result.Should().BeLessThan(1.0d);
        }
    }
}