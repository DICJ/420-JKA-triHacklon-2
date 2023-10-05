using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class EstPremierTest
    {
        [TestMethod()]
        public void EstPremierSimpleTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremier(23));
            Assert.IsFalse(CalculatriceCrypto.EstPremier(12));
        }

        [TestMethod()]
        public void EstPremierLimiteTest()
        {
            Assert.IsFalse(CalculatriceCrypto.EstPremier(1));
            Assert.IsTrue(CalculatriceCrypto.EstPremier(2));
        }

        [TestMethod()]
        public void EstPremierGrosTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremier(278_786_533));
            Assert.IsFalse(CalculatriceCrypto.EstPremier(27_109 * 15_199));
        }
        
        [TestMethod()]
        public void EstPremierMoyenTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremier(781_967_633));
            Assert.IsFalse(CalculatriceCrypto.EstPremier(2_579_609));
        }

        [TestMethod()]
        public void EstPremierGrosEncoreTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremier(336_954_173));
            Assert.IsFalse(CalculatriceCrypto.EstPremier(9_643 * 18_353));
        }

        [TestMethod()]
        public void EstPremierSophieGermainTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremierSophieGermain(82_223));
            Assert.IsFalse(CalculatriceCrypto.EstPremierSophieGermain(4_837_492));
            Assert.IsFalse(CalculatriceCrypto.EstPremierSophieGermain(689141));
        }

        [TestMethod()]
        public void EstPremierSophieGermainPetitTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremierSophieGermain(5));
            Assert.IsFalse(CalculatriceCrypto.EstPremierSophieGermain(7));
            Assert.IsTrue(CalculatriceCrypto.EstPremierSophieGermain(11));
        }

        [TestMethod()]
        public void EstPremierSurTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremierSur(164_447));
            Assert.IsFalse(CalculatriceCrypto.EstPremierSur(689_141));
        }

        [TestMethod()]
        public void EstPremierSurPetitTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstPremierSur(5));
            Assert.IsFalse(CalculatriceCrypto.EstPremierSur(29));
            Assert.IsTrue(CalculatriceCrypto.EstPremierSur(7));
        }

        [TestMethod()]
        public void EstPremierJumeau()
        {
            Assert.IsFalse(CalculatriceCrypto.EstJumeau(23));
            Assert.IsFalse(CalculatriceCrypto.EstJumeau(12));
            Assert.IsTrue(CalculatriceCrypto.EstJumeau(29));
            Assert.IsTrue(CalculatriceCrypto.EstJumeau(31));
        }

        [TestMethod()]
        public void EstPremierJumeauLarge()
        {
            Assert.IsTrue(CalculatriceCrypto.EstJumeau(557_519));
            Assert.IsTrue(CalculatriceCrypto.EstJumeau(557_521));
            Assert.IsTrue(CalculatriceCrypto.EstJumeau(27_941)); 
            Assert.IsFalse(CalculatriceCrypto.EstJumeau(28_069));
        }
    }
}