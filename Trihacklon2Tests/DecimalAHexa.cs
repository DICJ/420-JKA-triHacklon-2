using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class DecimalAHexaTest
    {
        [TestMethod()]
        public void DecimalAHexaTest29()
        {
            Assert.AreEqual("1D", CalculatriceCrypto.DecimalAHexa(29).Trim());
            Assert.AreEqual("CE", CalculatriceCrypto.DecimalAHexa(206).Trim());
        }

        [TestMethod()]
        public void DecimalAHexaTestBig()
        {
            string big = CalculatriceCrypto.DecimalAHexa(198_524_689).Trim();
            Assert.IsTrue(
                big == "BD53F11" ||
                big == "B D5 3F 11" ||
                big == "0B D5 3F 11");
        }

        [TestMethod()]
        public void DecimalAHexaTestOnes()
        {
            string ones = CalculatriceCrypto.DecimalAHexa(65_535).Trim();
            Assert.IsTrue(
                ones == "FFFF" ||
                ones == "FF FF");    
        }

        [TestMethod()]
        public void DecimalAHexaTestBigSeparateur()
        {
            string big = CalculatriceCrypto.DecimalAHexa(198_524_689).Trim();
            Assert.IsTrue(
                big == "B D5 3F 11" ||
                big == "0B D5 3F 11");
        }

        [TestMethod()]
        public void DecimalAHexaTestOnesSeparateur()
        {
            string ones = CalculatriceCrypto.DecimalAHexa(65_535).Trim();
            Assert.AreEqual("FF FF", ones);

        }

        [TestMethod()]
        public void DecimalAHexaTestBigLeading0s()
        {
            string big = CalculatriceCrypto.DecimalAHexa(198_524_689).Trim();
            Assert.AreEqual("0B D5 3F 11", big);
        }
    }
}