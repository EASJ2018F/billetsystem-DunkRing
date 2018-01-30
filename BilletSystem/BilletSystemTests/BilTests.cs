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
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //arrange
            var Bil = new Bil();

            //act
            int Pris = Bil.Pris();

            //assert
            Assert.AreEqual(25, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //arrange
            var Bil = new Bil();

            //act
            string Køretøj = Bil.Køretøj();

            //assert
            Assert.AreEqual("Bil", Køretøj);
        }
    }
}