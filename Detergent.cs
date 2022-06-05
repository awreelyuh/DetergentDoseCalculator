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

        public string BaseDose { get; set; }

        public Detergent(string? name, string baseDose)
        {
            Name = name;
            BaseDose = baseDose;
        }

        public void Announce()
        {
            Console.WriteLine("Based on a 7.5 kg washing machine capacity, you need " + BaseDose + " of " + Name + " for your main wash.");
        }
    }
}
