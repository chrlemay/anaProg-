using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAnaProg1Oef4
{
    public class Laptop : Computer
    {
        public string Schermgrootte { get; set; }
        private int Breedte { get; set; }
        private int Hoogte { get; set; }


        public Laptop(string merk, double prijs, string schermgrootte, int breedte, int hoogte)
            : base(merk, prijs)
        {
            Schermgrootte = schermgrootte;
            Breedte = breedte;
            Hoogte = hoogte;
            Prijs = prijs;

        }

        public string GetResolutie()
        {
            return Breedte + " x " + Hoogte;
        }
        public void SetResolutie(int newBreedte, int newHoogte)
        {
            Breedte = newBreedte;
            Hoogte = newHoogte;
        }

        public override string PrintInfo()
        {
            return $" \n Merk van de laptop : { Merk }   \n Prijs van de laptop : { Prijs }" + $" \n Grootte van het scherm { Schermgrootte } \n resolutie van scherm { GetResolutie() }  ";

        }
    }

}
/* public string GetResolutie()
       {
           return Breedte + " x " + Hoogte;
       }
       public void SetResolutie(int newBreedte, int newHoogte)
       {
           Breedte = newBreedte;
           Hoogte = newHoogte;
       }

       public override string PrintInfo()
       {
           return $" \n Merk van de computer : { Merk }   \n Prijs van de computer : { Prijs }" + $" \n Grootte van het scherm { Schermgrootte } \n resolutie van scherm { GetResolutie() }  ";

       }*/
