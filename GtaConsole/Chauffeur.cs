using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaConsole
{
    class Chauffeur : Persoon
    {
        public Chauffeur(string naam) : base(naam)
        {
        }

        public virtual void Rijbewijs(string naam)
        {
            Console.WriteLine("{0} heeft een rijbewijs.", naam);
        }
    }
}
