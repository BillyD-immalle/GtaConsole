using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaConsole
{
    class Brommer : Voertuig
    {
        public Brommer(ConsoleColor kleur) : base(kleur)
        {
        }
        public override void Rij()
        {
            Console2.WriteLine("De brommer rijdt...", ConsoleColor.Red);
        }
        public override void Stuur(int graden)
        {
            Console.WriteLine("De brommer draait {0}°", graden);            
        }
    }
}
