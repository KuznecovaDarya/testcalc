﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
