namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        public static Dictionary<string, Detergent> GetDetergents()
        {
            Detergent biozet = new Detergent("Biozet", "powder", 1.0f);
            Detergent omoRegular = new Detergent("OMO Regular", "powder", 1.5f);
            Detergent bCleanBaby = new Detergent("b clean Baby", "powder", 2.0f);
            Detergent radiant = new Detergent("Radiant", "liquid", 1.5f);
            Detergent persilUltimate = new Detergent("Persil Ultimate", "liquid", 1.0f);
            Detergent almat = new Detergent("Almat Laundry", "liquid", 1.5f);

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

            //foreach (KeyValuePair<string, Detergent> kvp in detergents)
            //{
            //    Console.WriteLine("{0}",
            //        kvp.Key, kvp.Value);
            //}

            return detergents;


        }


    }
}
