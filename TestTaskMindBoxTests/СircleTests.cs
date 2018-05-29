using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Geometry.Tests
{
    [TestClass()]
    public class СircleTests
    {
        [TestMethod()]
        public void СircleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Сircle(-1));

        }

        [TestMethod()]
        public void CalcAreaTest()
        {
            Assert.AreEqual(new Сircle(1).CalcArea(), 3.1415926535897932384626433832795, 1e-7);
        }
    }
}