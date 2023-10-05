using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class DecimalABinaireTest
    {
        [TestMethod()]
        public void DecimalABinaireTest29()
        {
            string vingtNeuf = CalculatriceCrypto.DecimalABinaire(29).Trim();
            Assert.IsTrue(
                vingtNeuf == "11101" || 
                vingtNeuf == "1 1101" || 
                vingtNeuf == "0001 1101");    
        }

        [TestMethod()]
        public void DecimalABinaireTestBig()
        {
            string big = CalculatriceCrypto.DecimalABinaire(198_524_689).Trim();
            Assert.IsTrue(
                big == "1011 1101 0101 0011 1111 0001 0001" ||
                big == "1011110101010011111100010001");
        }

        [TestMethod()]
        public void DecimalABinaireTestOnes()
        {
            string ones = CalculatriceCrypto.DecimalABinaire(65_535).Trim();
            Assert.IsTrue(
                ones == "1111 1111 1111 1111" ||
                ones == "1111111111111111");    
        }

        [TestMethod()]
        public void DecimalABinaireTest29Separateur()
        {
            string vingtNeuf = CalculatriceCrypto.DecimalABinaire(29).Trim();
            Assert.IsTrue(
                vingtNeuf == "1 1101" ||
                vingtNeuf == "0001 1101");
        }

        [TestMethod()]
        public void DecimalABinaireTestBigSeparateur()
        {
            string big = CalculatriceCrypto.DecimalABinaire(198_524_689).Trim();
            Assert.AreEqual("1011 1101 0101 0011 1111 0001 0001", big);
            string ones = CalculatriceCrypto.DecimalABinaire(65_535).Trim();
            Assert.AreEqual("1111 1111 1111 1111", ones);
        }

        [TestMethod()]
        public void DecimalABinaireTest29Leading0s()
        {
            string vingtNeuf = CalculatriceCrypto.DecimalABinaire(29).Trim();
            Assert.AreEqual("0001 1101", vingtNeuf);
        }
    }
}