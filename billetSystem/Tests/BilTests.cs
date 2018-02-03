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
    public class MCTests
    {
        [TestMethod]
        public void TestBilPris()
        {
            //Arrange
            Bil bil1 = new Bil();
            //Act
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
            MC mc3 = new MC();
            // Act
            mc3.Nummerplade = "12345678";
            // Assert
            Assert.AreEqual(8, mc3.NummerpladeBegrænser());
        }
    }
}
