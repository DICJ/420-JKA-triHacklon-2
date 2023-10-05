using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon2.Tests
{
    [TestClass()]
    public class TailleTest
    {
        [TestMethod()]
        public void EntropieTest()
        {
            Assert.AreEqual(23, CalculatriceCrypto.NbDeBits(7_352_837)); // 111 0000 0011 0010 0000 0101
        }

        [TestMethod()]
        public void EntropieLimiteTest()
        {
            Assert.AreEqual(1, CalculatriceCrypto.NbDeBits(1));
        }

        [TestMethod()]
        public void EntropiePetitTest()
        { 
            Assert.AreEqual(8, CalculatriceCrypto.NbDeBits(255));
            Assert.AreEqual(9, CalculatriceCrypto.NbDeBits(256));
        }

        [TestMethod()]
        public void NbOctetsTest()
        {
            Assert.AreEqual(3, CalculatriceCrypto.NbOctets(7_352_837));
        }

        [TestMethod()]
        public void NbOctetsLimiteTest()
        {
            Assert.AreEqual(1, CalculatriceCrypto.NbOctets(1));
        }
        
        [TestMethod()]
        public void NbOctetsPetitTest()
        { 
            Assert.AreEqual(1, CalculatriceCrypto.NbOctets(255));
            Assert.AreEqual(2, CalculatriceCrypto.NbOctets(256));
        }

        [TestMethod()]
        public void SommeDesChiffresTest()
        {
            Assert.AreEqual(35, CalculatriceCrypto.SommeDesChiffres(7_352_837));
            Assert.AreEqual(10, CalculatriceCrypto.SommeDesChiffres(1_333));
        }

        [TestMethod()]
        public void SommeDesChiffresEncoreTest()
        {
            Assert.AreEqual(1, CalculatriceCrypto.SommeDesChiffres(1));
            Assert.AreEqual(1, CalculatriceCrypto.SommeDesChiffres(10000));
        }

        [TestMethod()]
        public void SommeDesChiffresJusquaUnChiffreTest()
        {
            Assert.AreEqual(8, CalculatriceCrypto.SommeDesChiffresJusquaUnChiffre(7_352_837));
        }

        [TestMethod()]
        public void SommeDesChiffresJusquaUnChiffreEncoreTest()
        {
            Assert.AreEqual(1, CalculatriceCrypto.SommeDesChiffresJusquaUnChiffre(1_333));
        }

        [TestMethod()]
        public void ModeTest()
        {
            Assert.AreEqual(9, CalculatriceCrypto.Mode(39_999_138));
        }

        [TestMethod()]
        public void ModeTestEncore()
        {
            Assert.AreEqual(0, CalculatriceCrypto.Mode(1_902_938_000));
        }

        [TestMethod()]
        public void ModeTestLimite()
        {
            Assert.AreEqual(1, CalculatriceCrypto.Mode(1));
        }

        [TestMethod()]
        public void ModeChoixMultiple()
        {
            int mode = CalculatriceCrypto.Mode(1_334_569_694);
            Assert.IsTrue(mode == 3 || mode == 4 || mode == 6 || mode == 9);
        }

        [TestMethod()]
        public void NombreDeChiffreTest()
        {
            Assert.AreEqual(0, CalculatriceCrypto.NbDeChiffre(1_234_567_895, 0));
            Assert.AreEqual(0, CalculatriceCrypto.NbDeChiffre(2_034_567_890, 1));
            Assert.AreEqual(1, CalculatriceCrypto.NbDeChiffre(1_234_567_890, 2));
            Assert.AreEqual(2, CalculatriceCrypto.NbDeChiffre(1_233_567_890, 3));
            Assert.AreEqual(2, CalculatriceCrypto.NbDeChiffre(1_434_567_890, 4));
            Assert.AreEqual(0, CalculatriceCrypto.NbDeChiffre(1_234_067_890, 5));
            Assert.AreEqual(2, CalculatriceCrypto.NbDeChiffre(1_234_567_896, 6));
            Assert.AreEqual(1, CalculatriceCrypto.NbDeChiffre(1_234_567_890, 7));
            Assert.AreEqual(1, CalculatriceCrypto.NbDeChiffre(1_234_567_890, 8));
            Assert.AreEqual(2, CalculatriceCrypto.NbDeChiffre(1_234_569_890, 9));
        }

        [TestMethod()]
        public void NombreDeChiffreLimiteTest()
        { 
            Assert.AreEqual(1, CalculatriceCrypto.NbDeChiffre(1, 1));
            Assert.AreEqual(0, CalculatriceCrypto.NbDeChiffre(1, 3));
        }
    }
}