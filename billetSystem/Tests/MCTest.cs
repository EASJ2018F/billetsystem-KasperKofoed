using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using billetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public class MCTest
    {
        [TestMethod]
        public void TestMCPris()
        {
            //Arrange
            MC MC1 = new MC();
            //Act
            int pris = MC1.Pris();
            //Assert
            Assert.AreEqual(240, pris);


        }

        [TestMethod]
        public void KøretøjsTest()
        {
            //Arrange
            MC Harley = new MC();
            //Act
            string køretøj = Harley.KøretøjsBro();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}
