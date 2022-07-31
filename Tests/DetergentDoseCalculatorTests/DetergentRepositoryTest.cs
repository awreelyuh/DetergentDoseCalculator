using DetergentDoseCalculator;

namespace DetergentDoseCalculatorTests
{
    [TestClass]
    public class DetergentRepositoryTest
    {
        [TestMethod]
        //Project Feature: "Create 3 or more unit tests for your application" 2/3
        public void CalculateFinalDose_1KgOverDefaultMachineCapacity_GivesCorrectFinalDose()
        {
            //Arrange
            var detergentRepo = new DetergentRepository();
            var machineCapacity = "8.5";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(machineCapacity);
            Console.SetIn(stringReader);

            string expected = "For your 8.5 kg washing machine, you need 1.88 caps/scoops of Radiant liquid for your main wash.";

            //Act
            var actual = DetergentRepository.CalculateFinalDose("Radiant", "liquid", 1.5f);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Project Feature: "Create 3 or more unit tests for your application" 3/3
        public void CalculateFinalDose_1KgUnderDefaultMachineCapacity_DisplaysClarificationMessage()
        {
            //Arrange
            var detergentRepo = new DetergentRepository();
            var machineCapacity = "6.5";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(machineCapacity);
            Console.SetIn(stringReader);

            string expected = "Machine capacity needs to be greater than 7.5 kg.";

            //Act
            var actual = DetergentRepository.CalculateFinalDose("Radiant", "liquid", 1.5f);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Project Feature: "Create 3 or more unit tests for your application" 4/3
        public void CalculateFinalDose_InvalidInputFormat_AsksUserToRetry()
        {
            //Arrange
            var detergentRepo = new DetergentRepository();
            var machineCapacity = "test";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(machineCapacity);
            Console.SetIn(stringReader);

            string expected = "Press ENTER to try again.";

            //Act
            var actual = DetergentRepository.CalculateFinalDose("Radiant", "liquid", 1.5f);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}