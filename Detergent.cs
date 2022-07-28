﻿using System;
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

        public static string Announce(string Name, string Consistency, float BaseDose)
        {
            
            if (Name != null)
            {
                //Future TODO - Find out whether "cap/scoop" can change from singular to plural depending on BaseDose
                return $"Based on a 7.5 kg washing machine capacity, you need {BaseDose} cap/scoop of {Name} {Consistency} for your main wash."; 
            }
            else
            {
                return "Please try again.";
            }

        }
    }
}
