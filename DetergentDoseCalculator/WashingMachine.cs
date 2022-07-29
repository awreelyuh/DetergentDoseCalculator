namespace DetergentDoseCalculator
{
    public class WashingMachine
    {
        public string MachineName { get; set; }
        public bool MachineType { get; set; }
        public double MachineCapacity { get; set; }

        public static void CheckWashingMachineSize(Detergent? chosenDetergent)
        {
            Console.Write("\nIs your washer larger than 7.5 kg? Y/N: ");
            var isLarger = Console.ReadLine().ToUpper();

            if (isLarger == "Y")
            {
                string finalDoseStatement = DetergentRepository.CalculateFinalDose(chosenDetergent.Name, chosenDetergent.Consistency, chosenDetergent.BaseDose);
                Console.WriteLine(finalDoseStatement);
                Console.ReadLine();
            }
            else if (isLarger == "N")
            {
                Console.WriteLine("\nYou're good to go. Happy washing!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                CheckWashingMachineSize(chosenDetergent);
            }
        }
    }
}
