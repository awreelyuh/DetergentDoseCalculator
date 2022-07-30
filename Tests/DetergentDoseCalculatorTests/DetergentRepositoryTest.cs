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

            //Act
            var actual = DetergentRepository.CalculateFinalDose("Radiant", "liquid", 1.5f);

            //Assert
            //var actual = stringWriter.ToString();
            Assert.AreEqual($"For your {machineCapacity} kg washing machine, you need 1.88 caps/scoops of Radiant liquid for your main wash.", actual);
        }
    }
}