using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetergentDoseCalculator
{
    public class RefValue
    {
       
        public void announceRef(ref string refname, string refconsistency, float refdose)
        {
            if (refname != null)
            {
                Console.WriteLine($"Based on a 7.5 kg washing machine capacity, you need {refdose} cap/scoop of {refname} {refconsistency} for your main wash.");
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }

    }
}
