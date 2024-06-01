using Mathemancy.UnitTesting;
using System.Data;
using System.Numerics;

namespace Mathemancy.Randomness.Tests;

public abstract class RandomNumberGeneratorTester<TInstance, TNumber> : Tester<TInstance> where TInstance : class, IRandomNumberGenerator where TNumber : INumber<TNumber>, IMinMaxValue<TNumber>
{
    [TestMethod]
    public void Generate_Parameterless_ReturnBetweenTypeBoundaries()
    {
        //Arrange

        //Act
        var result = Instance.Generate<TNumber>();

        //Assert
        result.Should().BeInRange(TNumber.MinValue, TNumber.MaxValue);
    }

    [TestMethod]
    [DataRow(0, 2000)]
    [DataRow(-25000, 12000)]
    [DataRow(-10, 150)]
    public void Generate_WhenMinMax_ReturnBetweenBoundaries(long min, long max)
    {
        //Arrange
        var cMin = TNumber.CreateSaturating(min);
        var cMax = TNumber.CreateSaturating(max);

        //Act
        var result = Instance.Generate(cMin, cMax);

        //Assert
        result.Should().BeInRange(cMin, cMax);
    }


}