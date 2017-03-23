using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaConsole
{
    class Persoon
    {
        private string naam;

        public Persoon(string naam)
        {
            this.naam = naam;
        }

        public virtual void Rijbewijs()
        {
            Console.WriteLine("{0} heeft een rijbewijs.", naam);
        }
    }
}
