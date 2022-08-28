using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathClass;
namespace UnitTest
{
    [TestClass]
    public class TestBasicMath
    {

        [TestMethod]
        public void AddTwoPositiveInteger()
        {
            var result = BasicMath.Add(1, 1);
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void AddTwoNegativeInteger()
        {
            Assert.ThrowsException<ArgumentException>(() => BasicMath.Add(-1, -1));
        }

        [TestMethod]
        public void AddPositiveDoubleAndNegativeDouble()
        {
            var result = BasicMath.Add(1.0, -1.0);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(0, 0)]
        [DataRow(2, 2)]
        [DataRow(100, 200)]
        [DataRow(-1000, 200)]
        public void AddThreeGroupOfNumbers(int a, int b)
        {
            var result = BasicMath.Add(a, b);
            Assert.AreEqual(a + b, result);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void AddTwoLargeNumber()
        {
            var result = BasicMath.Add(int.MaxValue, int.MaxValue);
        }


    }
}
