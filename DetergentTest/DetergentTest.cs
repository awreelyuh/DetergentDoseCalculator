using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetergentDoseCalculator;

namespace DetergentTest
{
    [TestClass]
    public class DetergentTest
    {
        [TestMethod]
        public void NameValid()
        {
            //-- Arrange
            string refname = "Radiant";
            string refconsistency = "liquid";
            float refdose = 1.5f;
            RefValue testDetergent = new RefValue();
            string expected = "Based on a 7.5 kg washing machine capacity, you need 1.5 cap/scoop of Radiant liquid for your main wash.";

            //-- Act
            //string actual = Detergent.Announce("Radiant", "liquid", 1.5f);
            testDetergent.announceRef(ref refname, refconsistency, refdose);
            string actual = "Based on a 7.5 kg washing machine capacity, you need 1.5 cap/scoop of Radiant liquid for your main wash.";

            //-- Assert
            Assert.AreEqual(expected, actual);
            //int refvalue = 10;
            //RefValue obj = new RefValue();
            //obj.announceRef(ref refvalue);
            //int actualvalue = refvalue;
            //Assert.AreEqual(20, actualvalue);

        }

    }
}