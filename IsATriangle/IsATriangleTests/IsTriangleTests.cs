using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IsATriangle.Tests
{
    [TestClass()]
    public class IsTriangleTests
    {
        public Tuple<int, int, int, IsTriangle.TriangleType>[] TestInput =
        {
            Tuple.Create(0, 0, 0, IsTriangle.TriangleType.NotTriangle),
            Tuple.Create(15, 240, 0, IsTriangle.TriangleType.NotTriangle),
            Tuple.Create(2, 512, 511, IsTriangle.TriangleType.ScaleneTriangle),
            Tuple.Create(40, 42, 58, IsTriangle.TriangleType.RightTriangles),
            Tuple.Create(512, 1, 512, IsTriangle.TriangleType.IsoscelesTriangle),
            Tuple.Create(189, 322, 322, IsTriangle.TriangleType.IsoscelesTriangle),
            Tuple.Create(916, 363, 532, IsTriangle.TriangleType.NotTriangle),
            Tuple.Create(712, 712, 392, IsTriangle.TriangleType.IsoscelesTriangle),
            //Tuple.Create(512, 512, 512, IsTriangle.TriangleType.EquilateralTriangle),
        };
        [TestMethod()]
        public void IsATiangleTest()
        {
            foreach (var input in TestInput)
            {
                Assert.AreEqual(input.Item4,IsTriangle.IsATiangle(input.Item1, input.Item2, input.Item3));
            }
        }
    }
}