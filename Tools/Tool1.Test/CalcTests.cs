﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tool1.Test
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void TestCalcAdd()
        {
            int sum = Calc.Add(4, 5);
            Assert.AreEqual(9, sum, "Not equal");
        }

        [TestMethod]
        public void TestCalcAdd_Negative()
        {
            int sum = Calc.Add(10, 5);
            Assert.AreNotEqual(20, sum, "Should not be equal");
        }

        [TestMethod]
        public void TestCalcSubtract()
        {
            int sum = Calc.Subtract(7, 5);
            Assert.AreEqual(2, sum, "Not equal");
        }

        [TestMethod]
        public void TestCalcSubtract2()
        {
            int sum = Calc.Subtract(8, 5);
            Assert.AreEqual(3, sum, "Not equal");
        }

        [TestMethod]
        public void TestCalcMultiply()
        {
            int sum = Calc.Multiply(2, 5);
            Assert.AreEqual(10, sum, "Not equal");
        }

        [TestMethod]
        public void TestCalcDivide()
        {
            int sum = Calc.Divide(10, 5);
            Assert.AreEqual(2, sum, "Not equal");
        }
    }
}
