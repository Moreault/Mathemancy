using System.Collections.Generic;

namespace Mathemancy.Tests;

public class RectangleMergerTestBase : TestBase<RectangleMerger>
{

}

[TestClass]
public class RectangleMergerTest
{
    [TestClass]
    public class Merge : RectangleMergerTestBase
    {
        [TestMethod]
        public void WhenRectanglesNull_Throw()
        {
            //Arrange
            IReadOnlyList<Rectangle<float>> rectangles = null!;

            //Act
            Action action = () => Instance.Merge(rectangles);

            //Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void WhenContainsABunchOfDuplicatesOnTopOfEachOther_ReturnOneOfThem()
        {
            //Arrange
            var rectangle = Dummy.Create<Rectangle<float>>();
            var rectangles = new List<Rectangle<float>>
            {
                rectangle,
                rectangle with {},
                rectangle with {},
                rectangle with {},
                rectangle with {},
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>> { rectangle });
        }

        [TestMethod]
        public void WhenASmallerRectangleIsInsideALargerRectangle_ReturnOnlyLargerRectangle()
        {
            //Arrange
            var largeRectangle = new Rectangle<float>(0, 0, 100, 100);
            var smallerRectangle = new Rectangle<float>(50, 50, 10, 10);
            var rectangles = new List<Rectangle<float>>
            {
                largeRectangle,
                smallerRectangle
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>> { largeRectangle });
        }

        [TestMethod]
        public void WhenContainsTwoRectanglesNextToEachOther_Merge()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(0, 0, 50, 50),
                new(50, 0, 50, 50)
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>> { new Rectangle<float>(0, 0, 100, 50) });
        }

        [TestMethod]
        public void WhenContainsTwoRectanglesNextToEachOtherButOrderedBackwards_Merge()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(50, 0, 50, 50),
                new(0, 0, 50, 50),
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>> { new Rectangle<float>(0, 0, 100, 50) });
        }

        [TestMethod]
        public void WhenContainsThreeRectanglesNextToEachOther_Merge()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(0, 0, 50, 50),
                new(50, 0, 50, 50),
                new(100, 0, 50, 50)
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>> { new Rectangle<float>(0, 0, 150, 50) });
        }

        [TestMethod]
        public void WhenContainsThreeRectanglesInLShape_MergeIntoTwo()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(0, 0, 50, 50),
                new(50, 0, 50, 50),
                new(0, 50, 50, 50)
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>>
            {
                new(0,0, 100, 50),
                new(0, 50, 50, 50)
            });
        }

        [TestMethod]
        public void WhenContainsABunchOfSmallRectanglesInABiggerRectangularShape_ReturnSingleRectangle()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(0, 0, 50, 50),
                new(50, 0, 50, 50),
                new(100, 0, 50, 50),
                new(150, 0, 50, 50),

                new(0, 50, 50, 50),
                new(50, 50, 50, 50),
                new(100, 50, 50, 50),
                new(150, 50, 50, 50),
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>> { new Rectangle<float>(0, 0, 200, 100) });
        }

        [TestMethod]
        public void WhenContainsABunchOfSmallRectanglesWithOneMissingOnSecondLine_ReturnThreeRectangles()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(0, 0, 50, 50),
                new(50, 0, 50, 50),
                new(100, 0, 50, 50),
                new(150, 0, 50, 50),

                new(0, 50, 50, 50),
                new(50, 50, 50, 50),
                new(150, 50, 50, 50),
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(new List<Rectangle<float>>
            {
                new(0,0, 200, 50),
                new(0,50, 100, 50),
                new(150,50, 50, 50)
            });
        }

        [TestMethod]
        public void WhenTwoRectanglesAppart_ReturnSameTwoRectanles()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(0, 0, 50, 50),
                new(100, 100, 50, 50)
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(rectangles);
        }

        [TestMethod]
        public void WhenTwoRectanglesAppartButShareOneVertex_ReturnSameTwoRectangles()
        {
            //Arrange
            var rectangles = new List<Rectangle<float>>
            {
                new(0, 0, 50, 50),
                new(50, 50, 50, 50)
            };

            //Act
            var result = Instance.Merge(rectangles);

            //Assert
            result.Should().BeEquivalentTo(rectangles);
        }
    }
}