using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetergentDoseCalculator
{
    public class Detergent
    {
        public string Name { get; set; }
        public string Consistency { get; set; }

        public float BaseDose { get; set; }
               
        public Detergent(string name, string consistency, float baseDose)
        {
            Name = name;
            Consistency = consistency;
            BaseDose = baseDose;
        }

        public static void Announce(string Name, string Consistency, float BaseDose)
        {
            
            if (Name != null)
            {
                Console.WriteLine($"Based on a 7.5 kg washing machine capacity, you need {BaseDose} cap/scoop of {Name} {Consistency} for your main wash."); //TODO - Find out whether "cap/scoop" can change from singular to plural based on float >1
            }
            else
            {
                Console.WriteLine("Please try again.");
            }

        }
    }
}
