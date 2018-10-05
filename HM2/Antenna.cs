using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HM2
{
    public class Antenna
    {
        public int Price { get; set; }
        public string Material { get; set; }
        public int Diametre { get; set; }
        

        public Antenna(int price, string material, int diametre)
        {
            Price = price;
            Material = material;
            Diametre = diametre;
        }
        public virtual double Quality()
        {
            return (double)Diametre/Price;
        }
    }
}
