using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class DecimalAOctalTest
    {
        [TestMethod()]
        public void DecimalAOctalTest29()
        {
            string vingtNeuf = CalculatriceCrypto.DecimalAOctal(29).Trim();
            Assert.IsTrue(
                vingtNeuf == "35" || 
                vingtNeuf == "035");    
        }

        [TestMethod()]
        public void DecimalAOctalTestBig()
        {
            string big = CalculatriceCrypto.DecimalAOctal(19_852_489).Trim();
            Assert.IsTrue(
                big == "113566311" ||
                big == "113 566 311");
        }

        [TestMethod()]
        public void DecimalAOctalTestOnes()
        {
            string ones = CalculatriceCrypto.DecimalAOctal(65_535).Trim();
            Assert.IsTrue(
                ones == "177777" ||
                ones == "177 777");    
        }

        [TestMethod()]
        public void DecimalAOctalTestBigSeparateur()
        {
            string big = CalculatriceCrypto.DecimalAOctal(19_852_489).Trim();
            Assert.AreEqual("113 566 311", big);
        }

        [TestMethod()]
        public void DecimalAOctalTestOnesSeparateur()
        {
            string ones = CalculatriceCrypto.DecimalAOctal(65_535).Trim();
            Assert.AreEqual("177 777", ones);

        }

        [TestMethod()]
        public void DecimalAOctalTest29Leading0s()
        {
            string vingtNeuf = CalculatriceCrypto.DecimalAOctal(29).Trim();
            Assert.AreEqual("035", vingtNeuf);
        }
    }
}