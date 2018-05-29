using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Geometry.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(10, 1.99999999999, 12.0));

        }

        [TestMethod()]
        public void CalcAreaTest()
        {
            Assert.AreEqual(new Triangle(3,4,5).CalcArea(),6.0,1e-7);
        }

        [TestMethod()]
        public void IsRightTriangleTest()
        {
            Assert.IsTrue(new Triangle(3, 4, 5).IsRightTriangle());
            Assert.IsFalse(new Triangle(3, 4, 4).IsRightTriangle());

        }
    }
}