﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter15.RodCutting;

namespace UnitTest
{
    [TestClass]
    public class RodCuttingTests
    {
        [TestMethod]
        public void CutRod()
        {
            var p = new[] { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
            Assert.AreEqual(30, Algorithms.CutRod(p, p.Length - 0));
            Assert.AreEqual(25, Algorithms.CutRod(p, p.Length - 1));
            Assert.AreEqual(22, Algorithms.CutRod(p, p.Length - 2));
            Assert.AreEqual(18, Algorithms.CutRod(p, p.Length - 3));
        }
    }
}