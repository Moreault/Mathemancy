namespace Mathemancy.Tests;

[TestClass]
public class BoundariesTester
{
    [TestClass]
    public class SubtractionOperator : TestBase
    {
        [TestMethod]
        public void Always_Subtract()
        {
            //Arrange
            var a = Dummy.Create<Boundaries<int>>();
            var b = Dummy.Create<Boundaries<int>>();

            //Act
            var result = a - b;

            //Assert
            result.Should().BeEquivalentTo(new Boundaries<int>
            {
                Top = a.Top - b.Top,
                Right = a.Right - b.Right,
                Bottom = a.Bottom - b.Bottom,
                Left = a.Left - b.Left,
            });
        }
    }

    [TestClass]
    public class AddOperator : TestBase
    {
        [TestMethod]
        public void Always_Add()
        {
            //Arrange
            var a = Dummy.Create<Boundaries<int>>();
            var b = Dummy.Create<Boundaries<int>>();

            //Act
            var result = a + b;

            //Assert
            result.Should().BeEquivalentTo(new Boundaries<int>
            {
                Top = a.Top + b.Top,
                Right = a.Right + b.Right,
                Bottom = a.Bottom + b.Bottom,
                Left = a.Left + b.Left,
            });
        }
    }

    [TestClass]
    public class MultiplicationOperator : TestBase
    {
        [TestMethod]
        public void Always_Multiply()
        {
            //Arrange
            var a = Dummy.Create<Boundaries<int>>();
            var b = Dummy.Create<Boundaries<int>>();

            //Act
            var result = a * b;

            //Assert
            result.Should().BeEquivalentTo(new Boundaries<int>
            {
                Top = a.Top * b.Top,
                Right = a.Right * b.Right,
                Bottom = a.Bottom * b.Bottom,
                Left = a.Left * b.Left,
            });
        }
    }

    [TestClass]
    public class DivisionOperator : TestBase
    {
        [TestMethod]
        public void Always_Divide()
        {
            //Arrange
            var a = Dummy.Create<Boundaries<int>>();
            var b = Dummy.Create<Boundaries<int>>();

            //Act
            var result = a / b;

            //Assert
            result.Should().BeEquivalentTo(new Boundaries<int>
            {
                Top = a.Top / b.Top,
                Right = a.Right / b.Right,
                Bottom = a.Bottom / b.Bottom,
                Left = a.Left / b.Left,
            });
        }
    }

    [TestClass]
    public class GreaterThanOperator : TestBase
    {
        [TestMethod]
        public void WhenBIsCompletelyContainedInsideA_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a > b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsCompletelyContainedInsideB_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            var b = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherUp_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 2,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherRight_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 11,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherDown_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 17,
                Left = 4
            };

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherToTheLeft_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 1
            };

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAAndBAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 5,
                Right = 10,
                Bottom = 15,
                Left = 2
            };
            var b = a with { };

            //Act
            var result = a > b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class LesserThanOperator : TestBase
    {
        [TestMethod]
        public void WhenBIsCompletelyContainedInsideA_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsCompletelyContainedInsideB_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            var b = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherUp_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 2,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherRight_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 11,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherDown_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 17,
                Left = 4
            };

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherToTheLeft_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 1
            };

            //Act
            var result = a < b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAAndBAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 5,
                Right = 10,
                Bottom = 15,
                Left = 2
            };
            var b = a with { };

            //Act
            var result = a < b;

            //Assert
            result.Should().BeFalse();
        }
    }

    [TestClass]
    public class GreaterThanOrEqualOperator : TestBase
    {
        [TestMethod]
        public void WhenBIsCompletelyContainedInsideA_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAIsCompletelyContainedInsideB_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            var b = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherUp_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 2,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherRight_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 11,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherDown_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 17,
                Left = 4
            };

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherToTheLeft_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 1
            };

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAAndBAreEqual_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 5,
                Right = 10,
                Bottom = 15,
                Left = 2
            };
            var b = a with { };

            //Act
            var result = a >= b;

            //Assert
            result.Should().BeTrue();
        }
    }

    [TestClass]
    public class LesserThanOrEqualOperator : TestBase
    {
        [TestMethod]
        public void WhenBIsCompletelyContainedInsideA_ReturnFalse()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void WhenAIsCompletelyContainedInsideB_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            var b = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherUp_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 2,
                Right = 8,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherRight_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 11,
                Bottom = 9,
                Left = 4
            };

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherDown_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 17,
                Left = 4
            };

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenBIsInsideAButGoesFurtherToTheLeft_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 4,
                Right = 10,
                Bottom = 15,
                Left = 2
            };

            var b = new Boundaries<int>
            {
                Top = 6,
                Right = 8,
                Bottom = 9,
                Left = 1
            };

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void WhenAAndBAreEqual_ReturnTrue()
        {
            //Arrange
            var a = new Boundaries<int>
            {
                Top = 5,
                Right = 10,
                Bottom = 15,
                Left = 2
            };
            var b = a with { };

            //Act
            var result = a <= b;

            //Assert
            result.Should().BeTrue();
        }
    }
}