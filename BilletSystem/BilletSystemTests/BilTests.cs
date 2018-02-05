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
            var Bil = new Bil("3020129", DateTime.Now);

            //act
            int Pris = Bil.pris();

            //assert
            Assert.AreEqual(240, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //arrange
            var Bil = new Bil("3020129",DateTime.Now, true);

            //act
            string Køretøj = Bil.navngivelseAfKøretøj();

            //assert
            Assert.AreEqual("Bil", Køretøj);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "Nummerplade er længere end 7 cifre")]
        public void BilNummerpladeForLang()
        {
            //arrange 
            var Bil = new Bil("12312322", DateTime.Now, true);


        }
    }
}