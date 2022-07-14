namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        public static Dictionary<string, Detergent> GetDetergents()
        {
            Detergent biozet = new Detergent("BIOZET", "powder", 1.0f);
            Detergent omoRegular = new Detergent("OMO REGULAR", "powder", 1.5f);
            Detergent bCleanBaby = new Detergent("B CLEAN BABY", "powder", 2.0f);
            Detergent radiant = new Detergent("RADIANT", "liquid", 1.5f);
            Detergent persilUltimate = new Detergent("PERSIL ULTIMATE", "liquid", 1.0f);
            Detergent almat = new Detergent("ALMAT LAUNDRY", "liquid", 1.5f);

            var detergents = new Dictionary<string, Detergent>();
            detergents.Add(biozet.Name, biozet);
            detergents.Add(omoRegular.Name, omoRegular);
            detergents.Add(bCleanBaby.Name, bCleanBaby);
            detergents.Add(radiant.Name, radiant);
            detergents.Add(persilUltimate.Name, persilUltimate);
            detergents.Add(almat.Name, almat);

            foreach (var detergent in detergents.Values)
            {
                Console.WriteLine($"{detergent.Name} {detergent.Consistency}");
            }

            return detergents;
        }

        public static Dictionary<string, Detergent> detergents;

        public static Dictionary<string, Detergent> ReadAllDetergents()
        {
            return detergents;
        }

        public static string AnnounceDetails(Detergent detergent)
        {
            return $"Based on a 7.5 kg washing machine capacity, you need {detergent.BaseDose} cap / scoop of {detergent.Name} {detergent.Consistency} for your main wash.";
        }

    }
}
