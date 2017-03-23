using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Voertuig car = new Auto();
            Voertuig truck = new Vrachtwagen();

            truck.Stuur(5);
            car.Stuur(150);
            car.Rij();
            truck.Rij();
            truck.LaadLeeg();
        }
    }    
}
