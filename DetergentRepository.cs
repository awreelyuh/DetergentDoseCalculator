using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetergentDoseCalculator
{
    public class DetergentRepository
    {
        public static Dictionary<string, string> GetDetergents()
        {
            Dictionary<string, string> detergents = new Dictionary<string, string>();
            
            detergents.Add("Biozet powder", "1 scoop or 60 ml");
            detergents.Add("OMO powder", "1.5 scoops");
            detergents.Add("b clean co powder", "2 scoops");
            detergents.Add("Radiant liquid", "1.5 caps");
            detergents.Add("Kin Kin Naturals liquid", "90 ml (for hard water");
            
            return detergents;
        }
        
    }
}
