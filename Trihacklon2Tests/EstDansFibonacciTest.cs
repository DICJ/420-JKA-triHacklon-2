using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class EstDansFibonacciTest
    {
        [TestMethod()]
        public void EstDansFiboTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstDansFibonacci(2));
            Assert.IsFalse(CalculatriceCrypto.EstDansFibonacci(4));
        }

        [TestMethod()]
        public void EstDansFiboMoyen()
        {
            Assert.IsTrue(CalculatriceCrypto.EstDansFibonacci(317_811));
            Assert.IsFalse(CalculatriceCrypto.EstDansFibonacci(417_811));
        }

        [TestMethod()]
        public void EstDansFiboLargeTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstDansFibonacci(701_408_733));
            Assert.IsFalse(CalculatriceCrypto.EstDansFibonacci(701_408_734));
        }

        [TestMethod()]
        public void EstDansFiboPosition()
        {
            Assert.IsTrue(CalculatriceCrypto.EstDansFibonacci(2, out int p));
            Assert.AreEqual(3, p);
        }

        [TestMethod()]
        public void EstDansFiboMoyenPosition()
        {
            Assert.IsTrue(CalculatriceCrypto.EstDansFibonacci(317_811, out int p));
            Assert.AreEqual(28, p);
        }

        [TestMethod()]
        public void EstDansFiboLargePosition()
        {
            Assert.IsTrue(CalculatriceCrypto.EstDansFibonacci(701_408_733, out int p));
            Assert.AreEqual(44, p);
        }
    }
}