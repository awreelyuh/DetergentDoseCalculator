using DetergentDoseCalculator;

namespace DetergentDoseCalculatorTests
{
    [TestClass]
    public class DetergentTest
    {
        [TestMethod]
        public void Announce_ValidUserInput_PrintsDefaultDoseStatement()
        {
            //Arrange
            var detergent = new Detergent("Radiant", "liquid", 1.5f);
            string expected = "Based on a 7.5 kg washing machine capacity, you need 1.5 cap/scoop of Radiant liquid for your main wash.";

            //Act
            string actual = Detergent.Announce("Radiant", "liquid", 1.5f);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Announce_BlankUserInput_TryAgain()
        {
            //Arrange
            var detergent = new Detergent("Radiant", "liquid", 1.5f);
            string expected = "Please try again.";

            //Act
            string actual = Detergent.Announce("", "liquid", 1.5f);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}