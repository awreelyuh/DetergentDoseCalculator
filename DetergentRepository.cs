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
            detergents.Add(new Detergent("Biozet powder", "1 scoop or 60 ml"));
            detergents.Add(new Detergent("OMO powder", "1.5 scoops"));
            detergents.Add(new Detergent("b clean co powder", "2 scoops"));
            detergents.Add(new Detergent("Radiant liquid", "1.5 caps"));
            detergents.Add(new Detergent("Kin Kin Naturals liquid", "90 ml (for hard water"));
            return detergents;
        }
        
    }
}
