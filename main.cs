using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto, il prezzo del biglietto è di 5$");
            int soldi = Convert.ToInt32(Console.ReadLine());

            if(soldi < 5)
            {
                int cinque = 5;
                int soldi_mancanti = cinque - soldi;
                Console.WriteLine($"Non hai abbastanza soldi ! Devi mettere {soldi_mancanti}$ !");
            }
            else if(soldi == 5)
            {
                Console.WriteLine("Ecco il tuo biglietto !");
            }
            else
            {
                int resto = soldi - 5;
                Console.WriteLine($"Ecco il tuo biglietto e {resto}$ di resto !");
            }
        }
    }
}
