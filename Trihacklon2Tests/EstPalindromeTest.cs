using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class EstPalindromeTest
    {
        [TestMethod()]
        public void EstPalindromePairTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPalindrome(22));
            Assert.IsFalse(CalculatriceCrypto.EstPalindrome(54));
        }

        [TestMethod()]
        public void EstPalindromeGrosPairTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPalindrome(1_234_554_321));
            Assert.IsFalse(CalculatriceCrypto.EstPalindrome(1_234_564_321));
        }

        [TestMethod()]
        public void EstPalindromeImpairTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPalindrome(2));
            Assert.IsFalse(CalculatriceCrypto.EstPalindrome(367));

            Assert.IsTrue(CalculatriceCrypto.EstPalindrome(363));
        }

        [TestMethod()]
        public void EstPalindromeImpairGrosTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPalindrome(123_454_321));
            Assert.IsFalse(CalculatriceCrypto.EstPalindrome(123_454_361));
        }

        [TestMethod()]
        public void EstToutPareilTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstToutPareil(2));
            Assert.IsFalse(CalculatriceCrypto.EstToutPareil(202));
        }

        [TestMethod()]
        public void EstToutPareilGrosTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstToutPareil(1111111111));
            Assert.IsTrue(CalculatriceCrypto.EstToutPareil(222222));
            Assert.IsFalse(CalculatriceCrypto.EstToutPareil(1111111119));
        }
    }
}