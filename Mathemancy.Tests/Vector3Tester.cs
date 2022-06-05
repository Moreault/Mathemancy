using System;
using ToolBX.EasyTypeParsing;

namespace Mathemancy.Tests;

[TestClass]
public class Vector3Tester
{
    [TestClass]
    public class FromString : Tester
    {
        [TestMethod]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow(null)]
        public void WhenValueIsEmpty_Throw(string value)
        {
            //Arrange

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void WhenThereIsOnlyOneValue_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()})";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<Exception>().WithMessage($"Can't create Vector3 : Expecting 2 or 3 values but received 1");
        }

        [TestMethod]
        public void WhenThereAreFourValues_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, {Fixture.Create<float>()}, {Fixture.Create<float>()}, {Fixture.Create<float>()})";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<Exception>().WithMessage($"Can't create Vector3 : Expecting 2 or 3 values but received 4");
        }

        [TestMethod]
        public void WhenThereAreTwoValuesAndXIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"(three point five, {Fixture.Create<float>()})";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<StringParsingException<float>>();
        }

        [TestMethod]
        public void WhenThereAreTwoValuesAndYIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, forty-three point eighty-one)";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<StringParsingException<float>>();
        }

        [TestMethod]
        public void WhenThereAreTwoNumericValues_ReturnVectorWithXAndY()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();

            var value = $"({x}, {y})";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y));
        }

        [TestMethod]
        public void WhenThereAreThreeValuesAndZIsNotNumeric_Throw()
        {
            //Arrange
            var value = $"({Fixture.Create<float>()}, {Fixture.Create<float>()}, forty-three point eighty-one)";

            //Act
            var action = () => Vector3<float>.FromString(value);

            //Assert
            action.Should().Throw<StringParsingException<float>>();
        }

        [TestMethod]
        public void WhenThereAreThreeNumericValues_ReturnVectorWithXYZ()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();
            var z = Fixture.Create<float>();

            var value = $"({x}, {y}, {z})";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y, z));
        }

        [TestMethod]
        public void WhenThereAreTwoValuesWithoutParentheses_ReturnVectorWithXAndY()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();

            var value = $"{x}, {y}";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y));
        }

        [TestMethod]
        public void WhenThereAreThreeValuesWithoutParentheses_ReturnVectorWithXYZ()
        {
            //Arrange
            var x = Fixture.Create<float>();
            var y = Fixture.Create<float>();
            var z = Fixture.Create<float>();

            var value = $"{x}, {y}, {z}";

            //Act
            var result = Vector3<float>.FromString(value);

            //Assert
            result.Should().Be(new Vector3<float>(x, y, z));
        }
    }

}