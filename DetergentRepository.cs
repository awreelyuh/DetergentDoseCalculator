namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        //Project Feature: "Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program"
        public static Dictionary<string, Detergent> InitializeDetergents()
        {
            //Future TODO - Refigure dosage data to mls or grams instead of scoops or caps
            //Future TODO - Read data from an external CSV or JSON file extracted from CCN's web API
            Detergent biozet = new("Biozet", "powder", 1.0f);
            Detergent omoRegular = new("OMO Regular", "powder", 1.5f);
            Detergent bCleanBaby = new("b clean baby", "powder", 2.0f);
            Detergent radiant = new("Radiant", "liquid", 1.5f);
            Detergent persilUltimate = new("Persil Ultimate", "liquid", 1.0f);
            Detergent almat = new("Almat Laundry", "liquid", 1.5f);

            var detergents = new Dictionary<string, Detergent>
            {
                { biozet.Name, biozet },
                { omoRegular.Name, omoRegular },
                { bCleanBaby.Name, bCleanBaby },
                { radiant.Name, radiant },
                { persilUltimate.Name, persilUltimate },
                { almat.Name, almat }
            };

            return detergents;
        }
        //Project Feature: "Build a conversion tool that converts user input to another type and displays it"
        public static string CalculateFinalDose(string Name, string Consistency, float BaseDose)
        {
            double machineCapacity = Convert.ToDouble(Console.ReadLine());
            double increasedDetergentDose = ((BaseDose * 0.25) * (machineCapacity - 7.5) + BaseDose); //Detergent quantities are based on a 7.5 kg capacity washing machine. Increase main wash dose by 25% for each additional kg.
            var finalDetergentDose = Math.Round(increasedDetergentDose, 2);
            return "For your " + machineCapacity + " kg washing machine, you need " + finalDetergentDose + " caps/scoops of " + Name + " " + Consistency + " for your main wash.";
        }
    }
}
