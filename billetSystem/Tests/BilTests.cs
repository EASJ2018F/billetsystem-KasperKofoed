using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using billetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class BilTests
    {
        [TestMethod]
        public void TestBilPris()
        {
            //Arrange
            Bil bil1 = new Bil();
            //Act
            bil1.KøretøjsPrisen();
            bil1.Brobizz = false;
            int pris = bil1.Pris();

            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void KøretøjsTest()
        {
            //Arrange
            Bil McLaren = new Bil();
            //Act
            string køretøj = McLaren.KøretøjsBro();
            //Assert
            Assert.AreEqual("Bil", køretøj);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void McNummerpladeLængdeTest()
        {
            // Arrange
            Bil bil3 = new Bil();
            // Act
            bil3.Nummerplade = "1234567";
            // Assert
            Assert.AreEqual(8, bil3.NummerpladeBegrænser());
        }
    }
}
