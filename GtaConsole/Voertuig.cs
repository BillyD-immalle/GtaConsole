using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaConsole
{
    class Voertuig       
    {
        private ConsoleColor kleur;

        public Voertuig(ConsoleColor kleur)
        {
            this.kleur = kleur;
        }       

        public virtual void Rij()
        {
           
        }

        public virtual void Stuur(int graden)
        {
            
        }
        public virtual void LaadLeeg()
        {
            
        }
    }
}
