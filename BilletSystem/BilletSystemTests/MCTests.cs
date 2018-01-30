using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //arrange
            var MC = new MC();

            //act
            int Pris = MC.Pris();

            //assert
            Assert.AreEqual(125, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //arrange
            var MC = new MC();

            //act
            string Køretøj = MC.Køretøj();

            //assert
            Assert.AreEqual("MC", Køretøj);
        }
    }
}