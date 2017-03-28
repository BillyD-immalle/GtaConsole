using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaConsole
{
    abstract class Voertuig       
    {
        private ConsoleColor green;

        public Voertuig(ConsoleColor green)
        {
            this.green = green;
        }

        public abstract void Rij();

        public abstract void Stuur(int graden);


    }
}
