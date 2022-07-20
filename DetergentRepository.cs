namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        public static Dictionary<string, Detergent> InitializeDetergents()
        {
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
    }
}
