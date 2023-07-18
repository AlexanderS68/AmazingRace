using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazingRaceSolution.Tests{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFindPath_PositiveCase()
        {
            var maze = new int[][]{
                new int[]{ 0, 0, 0, 0, 1, 0 },
                new int[]{ 0, 1, 1, 1, 1, 0 },
                new int[]{ 0, 1, 0, 0, 0, 0 },
                new int[]{ 0, 1, 1, 1, 1, 1 },
                new int[]{ 0, 0, 0, 0, 0, 1 }
            };

            var start = new Point(0, 4);
            var end = new Point(4, 5);
        
            var result = AmazingRaceSolution.Solution.FindPath(maze, start, end, new List<Point> { start });

            var expected = new List<Point>
            {
                new Point(0, 4),
                new Point(1, 4),
                new Point(1, 3),
                new Point(1, 2),
                new Point(1, 1),
                new Point(2, 1),
                new Point(3, 1),
                new Point(3, 2),
                new Point(3, 3),
                new Point(3, 4),
                new Point(3, 5),
                new Point(4, 5)   
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFindPath_UnreachableStart()
        {
            var maze = new int[][]{
                new int[]{ 0, 0, 0, 0, 1 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 1, 0, 0, 0, 1 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 1, 0, 0, 0, 0 }
            };

            var start = new Point(0, 0);
            var end = new Point(4, 4);

            var result = AmazingRaceSolution.Solution.FindPath(maze, start, end, new List<Point> { start });

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestFindPath_SameStartAndEnd()
        {
            var maze = new int[][]{
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 1, 1, 1, 1, 1 }
            };

            var start = new Point(0, 0);
            var end = new Point(0, 0);

            var result = AmazingRaceSolution.Solution.FindPath(maze, start, end, new List<Point> { start });

            var expected = new List<Point>
            {
                new Point(0, 0)
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFindPath_NegativeCase()
        {
            var maze = new int[][]{
                new int[]{ 0, 0, 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0, 0, 0 }
            };

            var start = new Point(0, 0);
            var end = new Point(4, 4);
        
            var result = AmazingRaceSolution.Solution.FindPath(maze, start, end, new List<Point> { start });

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestFindPath_SingleValidPath()
        {
            var maze = new int[][]{
                new int[]{ 1, 0, 0, 0, 0 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 0, 0, 0, 0, 1 },
                new int[]{ 0, 0, 0, 0, 1 },
                new int[]{ 0, 0, 0, 0, 1 }
            };

            var start = new Point(0, 0);
            var end = new Point(4, 4);
        
            var result = AmazingRaceSolution.Solution.FindPath(maze, start, end, new List<Point> { start });

            var expected = new List<Point>
            {
                new Point(0, 0),
                new Point(1, 0),
                new Point(1, 1),
                new Point(1, 2),
                new Point(1, 3),
                new Point(1, 4),
                new Point(2, 4),
                new Point(3, 4),
                new Point(4, 4)
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
