using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAnaProg1Oef4
{
    public abstract class Computer
    {
        public string Merk { get; set; }
        public double Prijs { get; set; }



        public Computer(string merk, double prijs)
        {
            Merk = merk;
            Prijs = prijs;
        }

        public void PrijsAanpassen(double huidigePrijs)
        {
            Prijs = Prijs + huidigePrijs;
        }

        public virtual string PrintInfo()
        {

            return ($"Merk computer :{ Merk } \n prijs computer : { Prijs }");

        }


    }
}
