using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaConsole
{
    class Auto : Voertuig
    {
        public Auto() : base(ConsoleColor.DarkYellow)
        {
        }        
        public override void Rij()
        {
            Console2.WriteLine("De auto rijdt...", ConsoleColor.Green);
        }
        public override void Stuur(int graden)
        {
            Console.WriteLine("De auto bestuurder draait {0}°", graden);            
        }
    }
}
