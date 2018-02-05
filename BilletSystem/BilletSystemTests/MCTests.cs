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
            var MC = new MC("3020129", DateTime.Now);

            //act
            int Pris = MC.pris();

            //assert
            Assert.AreEqual(125, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //arrange
            var MC = new MC("3020129", DateTime.Now);

            //act
            string Køretøj = MC.navngivelseAfKøretøj();

            //assert
            Assert.AreEqual("MoterCykel", Køretøj);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "Nummerplade er længere end 7 cifre")]
        public void MCNummerpladeForLang()
        {
            //arrange 
            var MC = new MC("12312322", DateTime.Now);


        }
    }
}