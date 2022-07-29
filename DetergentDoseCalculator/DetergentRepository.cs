namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        public static Dictionary<string, Detergent> InitializeDetergents()
        {
            //Future TODO - Refigure dosage data to mls or grams instead of scoops or caps
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

        public static string CalculateFinalDose(string Name, string Consistency, float BaseDose)
        {
            Console.Write("How many kg is your washing machine capacity? ");
            double machineCapacity = Convert.ToDouble(Console.ReadLine());
            double increasedDetergentDose = (BaseDose + ((machineCapacity - 7.5) * 0.25));
            var finalDetergentDose = Math.Round(increasedDetergentDose, 2);
            return "For your " + machineCapacity + " kg washing machine, you need " + finalDetergentDose + " caps/scoops of " + Name + " " + Consistency + " for your main wash.";
        }
    }
}
