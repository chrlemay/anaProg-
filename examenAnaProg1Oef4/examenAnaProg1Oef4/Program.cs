using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAnaProg1Oef4
{ 
    class Program
    {
        static void Main(string[] args)
        {
            {
                /***************************************************************************************
                 * mijn unit testen om te zien of de onderdelen op zichzelf goed geprogrammeerd werden *
                 ***************************************************************************************
                 * 
                var mijnComputer = new Computer("Dell", 1500);
                Console.WriteLine(mijnComputer.PrintInfo());

                var mijnPC = new PC("Dell", 1500,"Groen","Bureau");
                Console.WriteLine(mijnPC.PrintInfo());

                mijnPC.PrijsAanpassen(150);
                Console.WriteLine(mijnPC.PrintInfo());

                var mijnLaptop = new Laptop("Medion",888, "17 inch", 1920, 1080);
                //mijnLaptop.Hoogte = 1500;   // moet steeds hoogte en breedte  samen ingeven 
                Console.WriteLine(mijnLaptop.PrintInfo());

                mijnLaptop.PrijsAanpassen(200);


                mijnLaptop.SetResolutie(1500, 1200);
                Console.WriteLine(mijnLaptop.PrintInfo());
               */

                Console.WriteLine("geef je gewenste computer merk : ");
                string merk = Console.ReadLine();

                Console.WriteLine("geef een prijs voor uw computer? ");
                double prijs = double.Parse(Console.ReadLine());

                Console.WriteLine("kleur");
                string kleur = Console.ReadLine();

                Console.WriteLine("meerprijs kleur: ");
                double meerprijs = double.Parse(Console.ReadLine());


                Console.WriteLine("werkplaats");
                string werkplaats = Console.ReadLine();


                //Aanmaak PC
                var mijnPC = new PC(merk, prijs, kleur, werkplaats);
                mijnPC.PrijsAanpassen(meerprijs);

                //Wijzigen PC
                Console.WriteLine("\n info over PC \n*****************");
                Console.WriteLine(mijnPC.PrintInfo());
                Console.WriteLine("\n _________________");

                //  resolutie 1920 X 1080 laptop
                Console.WriteLine("\n***************** \n De scherm grootte van de laptop in ich ?");
                string schermgrootte = Console.ReadLine();

                Console.WriteLine(" Wat is laptop scherm breedte = resolutie?");
                int breedte = int.Parse(Console.ReadLine());

                Console.WriteLine(" Wat is laptop scherm lengte = resolute? ");
                int hoogte = int.Parse(Console.ReadLine());

                //Aanmaak Laptop
                var mijnLaptop = new Laptop(merk, prijs, schermgrootte, breedte, hoogte);
                Console.WriteLine("\n info over Laptop \n*****************");
                Console.WriteLine(mijnLaptop.PrintInfo());


                //Methodes Laptop

                Console.WriteLine("prijsverhoging  voor aanpassen laptop = X euro");
                mijnLaptop.PrijsAanpassen(Double.Parse(Console.ReadLine()));
                Console.WriteLine("aanpassen resolutie 1st hoogte, dan breedte ingeven");
                mijnLaptop.SetResolutie(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

                Console.WriteLine(" \n*************************** \n info over aangepaste Laptop  \n***************************");
                Console.WriteLine(mijnLaptop.PrintInfo());



                Console.ReadLine();
            }
        }
    }
}