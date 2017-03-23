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
            Persoon loes = new Persoon("Loes");

            truck.Stuur(5);
            car.Stuur(50);
            car.Rij();
            truck.Rij();
            truck.LaadLeeg();
            loes.Rijbewijs();


        }
    }    
}
