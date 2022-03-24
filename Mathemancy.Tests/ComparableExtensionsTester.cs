using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolBX.Eloquentest;
using ToolBX.Mathemancy;

namespace Mathemancy.Tests;

[TestClass]
public class ComparableExtensionsTester
{
    [TestClass]
    public class IsGreaterThan : Tester
    {
        [TestMethod]
        public void WhenIntIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 14;
            var comp = 13;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenIntIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 2;
            var comp = 3;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenIntIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 78;
            var comp = 78;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenLongIsGreaterThan_ReturnTrue()
        {
            //Arrange
            long actual = 2000;
            long comp = 1999;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenLongIsLesserThan_ReturnFalse()
        {
            //Arrange
            long actual = 5678;
            long comp = 5679;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenLongIsEqualTo_ReturnFalse()
        {
            //Arrange
            long actual = 20000;
            long comp = 20000;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenUIntIsGreaterThan_ReturnTrue()
        {
            //Arrange
            uint actual = 97;
            uint comp = 96;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenUIntIsLesserThan_ReturnFalse()
        {
            //Arrange
            uint actual = 54;
            uint comp = 96;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenUIntIsEqualTo_ReturnFalse()
        {
            //Arrange
            uint actual = 241;
            uint comp = 241;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenByteIsGreaterThan_ReturnTrue()
        {
            //Arrange
            byte actual = 234;
            byte comp = 233;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenByteIsLesserThan_ReturnFalse()
        {
            //Arrange
            byte actual = 98;
            byte comp = 121;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenByteIsEqualTo_ReturnFalse()
        {
            //Arrange
            byte actual = 14;
            byte comp = 14;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenFloatIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 56.01f;
            var comp = 55.9f;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenFloatIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 81.56f;
            var comp = 95.67f;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenFloatIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 2345.14f;
            var comp = 2345.14f;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDoubleIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.04;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDoubleIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.13;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDoubleIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 8924.2345;
            var comp = 8924.2345;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDecimalIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 15.66m;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDecimalIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 21.89m;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDecimalIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 124678.9272m;
            var comp = 124678.9272m;

            //Act
            var result = actual.IsGreaterThan(comp);

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class IsGreaterThanOrEqualTo : Tester
    {
        [TestMethod]
        public void WhenIntIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 14;
            var comp = 13;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenIntIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 2;
            var comp = 3;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenIntIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 78;
            var comp = 78;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenLongIsGreaterThan_ReturnTrue()
        {
            //Arrange
            long actual = 2000;
            long comp = 1999;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenLongIsLesserThan_ReturnFalse()
        {
            //Arrange
            long actual = 5678;
            long comp = 5679;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenLongIsEqualTo_ReturnTrue()
        {
            //Arrange
            long actual = 20000;
            long comp = 20000;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenUIntIsGreaterThan_ReturnTrue()
        {
            //Arrange
            uint actual = 97;
            uint comp = 96;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenUIntIsLesserThan_ReturnFalse()
        {
            //Arrange
            uint actual = 54;
            uint comp = 96;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenUIntIsEqualTo_ReturnTrue()
        {
            //Arrange
            uint actual = 241;
            uint comp = 241;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenByteIsGreaterThan_ReturnTrue()
        {
            //Arrange
            byte actual = 234;
            byte comp = 233;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenByteIsLesserThan_ReturnFalse()
        {
            //Arrange
            byte actual = 98;
            byte comp = 121;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenByteIsEqualTo_ReturnTrue()
        {
            //Arrange
            byte actual = 14;
            byte comp = 14;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenFloatIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 56.01f;
            var comp = 55.9f;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenFloatIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 81.56f;
            var comp = 95.67f;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenFloatIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 2345.14f;
            var comp = 2345.14f;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDoubleIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.04;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDoubleIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.13;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDoubleIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 8924.2345;
            var comp = 8924.2345;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDecimalIsGreaterThan_ReturnTrue()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 15.66m;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDecimalIsLesserThan_ReturnFalse()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 21.89m;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDecimalIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 124678.9272m;
            var comp = 124678.9272m;

            //Act
            var result = actual.IsGreaterThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class IsLesserThan : Tester
    {
        [TestMethod]
        public void WhenIntIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 14;
            var comp = 13;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenIntIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 2;
            var comp = 3;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenIntIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 78;
            var comp = 78;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenLongIsGreaterThan_ReturnFalse()
        {
            //Arrange
            long actual = 2000;
            long comp = 1999;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenLongIsLesserThan_ReturnTrue()
        {
            //Arrange
            long actual = 5678;
            long comp = 5679;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenLongIsEqualTo_ReturnFalse()
        {
            //Arrange
            long actual = 20000;
            long comp = 20000;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenUIntIsGreaterThan_ReturnFalse()
        {
            //Arrange
            uint actual = 97;
            uint comp = 96;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenUIntIsLesserThan_ReturnTrue()
        {
            //Arrange
            uint actual = 54;
            uint comp = 96;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenUIntIsEqualTo_ReturnFalse()
        {
            //Arrange
            uint actual = 241;
            uint comp = 241;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenByteIsGreaterThan_ReturnFalse()
        {
            //Arrange
            byte actual = 234;
            byte comp = 233;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenByteIsLesserThan_ReturnTrue()
        {
            //Arrange
            byte actual = 98;
            byte comp = 121;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenByteIsEqualTo_ReturnFalse()
        {
            //Arrange
            byte actual = 14;
            byte comp = 14;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenFloatIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 56.01f;
            var comp = 55.9f;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenFloatIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 81.56f;
            var comp = 95.67f;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenFloatIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 2345.14f;
            var comp = 2345.14f;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDoubleIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.04;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDoubleIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.13;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDoubleIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 8924.2345;
            var comp = 8924.2345;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDecimalIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 15.66m;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDecimalIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 21.89m;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDecimalIsEqualTo_ReturnFalse()
        {
            //Arrange
            var actual = 124678.9272m;
            var comp = 124678.9272m;

            //Act
            var result = actual.IsLesserThan(comp);

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class IsLesserThanOrEqualTo : Tester
    {
        [TestMethod]
        public void WhenIntIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 14;
            var comp = 13;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenIntIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 2;
            var comp = 3;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenIntIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 78;
            var comp = 78;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenLongIsGreaterThan_ReturnFalse()
        {
            //Arrange
            long actual = 2000;
            long comp = 1999;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenLongIsLesserThan_ReturnTrue()
        {
            //Arrange
            long actual = 5678;
            long comp = 5679;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenLongIsEqualTo_ReturnTrue()
        {
            //Arrange
            long actual = 20000;
            long comp = 20000;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenUIntIsGreaterThan_ReturnFalse()
        {
            //Arrange
            uint actual = 97;
            uint comp = 96;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenUIntIsLesserThan_ReturnTrue()
        {
            //Arrange
            uint actual = 54;
            uint comp = 96;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenUIntIsEqualTo_ReturnTrue()
        {
            //Arrange
            uint actual = 241;
            uint comp = 241;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenByteIsGreaterThan_ReturnFalse()
        {
            //Arrange
            byte actual = 234;
            byte comp = 233;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenByteIsLesserThan_ReturnTrue()
        {
            //Arrange
            byte actual = 98;
            byte comp = 121;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenByteIsEqualTo_ReturnTrue()
        {
            //Arrange
            byte actual = 14;
            byte comp = 14;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenFloatIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 56.01f;
            var comp = 55.9f;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenFloatIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 81.56f;
            var comp = 95.67f;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenFloatIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 2345.14f;
            var comp = 2345.14f;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDoubleIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.04;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDoubleIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 4589.12;
            var comp = 4589.13;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDoubleIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 8924.2345;
            var comp = 8924.2345;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDecimalIsGreaterThan_ReturnFalse()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 15.66m;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenDecimalIsLesserThan_ReturnTrue()
        {
            //Arrange
            var actual = 15.67m;
            var comp = 21.89m;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenDecimalIsEqualTo_ReturnTrue()
        {
            //Arrange
            var actual = 124678.9272m;
            var comp = 124678.9272m;

            //Act
            var result = actual.IsLesserThanOrEqualTo(comp);

            //Assert
            result.Should().BeTrue();
        }
    }
}