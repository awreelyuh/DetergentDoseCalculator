using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        public static List<Detergent> GetDetergents()
        {
            List<Detergent> detergents = new List<Detergent>();
            detergents.Add(new Detergent("Biozet", 1f));
            detergents.Add(new Detergent("OMO", 1.5f));
            detergents.Add(new Detergent("b clean co", 2f));
            return detergents;
        }
        
    }
}
