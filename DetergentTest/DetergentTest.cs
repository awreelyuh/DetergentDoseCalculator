using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetergentDoseCalculator;

namespace DetergentTest
{
    [TestClass]
    public class DetergentTest
    {
        [TestMethod]
        public void NameValid()
        {
            //-- Arrange
            Detergent detergent = new Detergent("Radiant", "liquid", 1.5f);
            //static string Announce();
            string expected = "Based on a 7.5 kg washing machine capacity, you need 1.5 cap/scoop of Radiant liquid for your main wash.";

            //-- Act
            string actual = Detergent.Announce("Radiant", "liquid", 1.5f);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NameInvalid()
        {
            //-- Arrange


            //-- Act


            //-- Assert
            //Assert.AreEqual(expected, actual);
        }
    }
}