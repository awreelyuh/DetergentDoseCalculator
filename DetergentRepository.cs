namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        public static Dictionary<string, string> GetDetergents()
        {
            var detergents = new Dictionary<string, string>();

            detergents.Add("Biozet powder", "1 scoop or 60 ml");
            detergents.Add("OMO powder", "1.5 scoops");
            detergents.Add("b clean co powder", "2 scoops");
            detergents.Add("Radiant liquid", "1.5 caps");
            detergents.Add("Kin Kin Naturals liquid", "90 ml (for hard water)");

            foreach (KeyValuePair<string, string> kvp in detergents)
            {
                Console.WriteLine("{0}",
                    kvp.Key, kvp.Value);
            }

            return detergents;


        }


    }
}
