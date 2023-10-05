using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class EstSemiPremierTest
    {
        [TestMethod()]
        public void EstSemiPremierSimpleTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(22));
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(12));
        }

        [TestMethod()]
        public void EstSemiPremierSimpleEncoreTest()
        {
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(23));
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(29 * 23 * 11));
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(29 * 23));
        }

        [TestMethod()]
        public void EstSemiPremierLimiteTest()
        {
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(1));
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(2));
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(3));
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(4));
        }

        [TestMethod()]
        public void EstSemiPremierSimpleLargeTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(29_077 * 15_161));
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(3_533 * 691 * 607));
        }

        [TestMethod()]
        public void EstSemiPremierSimpleEncoreLargeTest()
        {
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(1_362_941_563));
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(8_069 * 26_119));
        }

        [TestMethod()]
        public void EstSemiPremierOutputsTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(22, out int p, out int q));
            Assert.IsTrue(p == 11 || q == 11);
            Assert.IsTrue(p == 2 || q == 2);
        }

        [TestMethod()]
        public void EstSemiPremierOutputLargeTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(27_109 * 15_199,
                   out int p, out int q));
            Assert.IsTrue(p == 27_109 || q == 27_109);
            Assert.IsTrue(p == 15_199 || q == 15_199);

            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(2_803 * 317 * 883));
            Assert.IsFalse(CalculatriceCrypto.EstSemiPremier(313_675_393));
        }

        [TestMethod()]
        public void EstSemiPremierOutputMoyenTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(8_069 * 26_119, out int p, out int q));
            Assert.IsTrue(p == 8_069 || q == 8_069);
            Assert.IsTrue(p == 26_119 || q == 26_119);
        }

        public void EstSemiPremierOutputPetitTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(4, out int p, out int q));

            Assert.AreEqual(2, p);
            Assert.AreEqual(2, q);
        }

        public void EstSemiPremierOutputPetitPareilTest()
        {
            Assert.IsTrue(CalculatriceCrypto.EstSemiPremier(29 * 23, out int p, out int q));

            Assert.IsTrue(p == 29 || q == 29);
            Assert.IsTrue(p == 23 || q == 23);
        }
    }
}