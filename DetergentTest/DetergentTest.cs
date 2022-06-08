using System;
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
            Detergent detergent = new Detergent("Tide", "line 3");
            //static string Announce();
            string expected = "Based on a 7.5 kg washing machine capacity, you need line 3 of Tide for your main wash.";

            //-- Act
            string actual = detergent.Announce();

            //-- Assert
            Assert.AreEqual(expected,actual);
        }
    }
}