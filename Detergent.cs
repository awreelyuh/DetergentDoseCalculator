using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetergentDoseCalculator
{
    public class Detergent
    {
        public string? Name { get; set; }

        public float BaseDose { get; set; }

        public Detergent(string? name, float baseDose)
        {
            Name = name;
            BaseDose = baseDose;
        }

        public void Announce()
        {
            Console.WriteLine("Based on a 7.5 kg washing machine capacity, you need " + BaseDose + " scoops/caps of " + Name + " for your main wash.");
        }
    }
}
