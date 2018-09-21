using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAnaProg1Oef4
{
    public class PC : Computer
    {
        public string Werklpaats { get; set; }
        public string KLeur { get; set; }

        public PC(string merk, double prijs, string kleur, string werkplaats)
            : base(merk, prijs)
        {
            Werklpaats = werkplaats;
            KLeur = kleur;
        }

        public override string PrintInfo()
        {

            return $" \n Merk van de computer: { Merk }   \n Prijs van de computer : { Prijs }" + $" \n werkplaats voor uw PC: {  Werklpaats  }  \n  kleur van PC : { KLeur }";
        }

    }
}
