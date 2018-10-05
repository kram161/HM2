using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HM2
{
    class AntennaQuality : Antenna
    {
        public string SuspensionType { get; set; }
        public AntennaQuality(string suspensiontype, int price, string material, int diametre):base(price,material,diametre)
        {
            SuspensionType = suspensiontype;
        }

        public override double Quality()
        {
            if (SuspensionType == "Azimutyalnayaya")
                return base.Quality();
            if (SuspensionType == "Polyarnaya")
                return 2*base.Quality();
            if (SuspensionType == "torodialniy")
                return 2.5 * base.Quality();
            else return -1;
        }
    }
}
