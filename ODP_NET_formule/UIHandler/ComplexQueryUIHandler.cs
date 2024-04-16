using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_formule.UIHandler
{
    public class ComplexQueryUIHandler
    {
		// TODO uncomment
        // private static readonly DrzavaService drzavaService = new DrzavaService();
        // private static readonly VozacService vozacService = new VozacService();
        // private static readonly RezultatService rezultatService = new RezultatService();
        // private static readonly StazaService stazaService = new StazaService();

        public void HandleComplexQueryMenu()
        {
            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite funkcionalnost:");
                Console.WriteLine("1  - ");
                Console.WriteLine("2  - ");
                Console.WriteLine("3  - ");
                Console.WriteLine("X  - Izlazak iz kompleksnih upita");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
						//TODO:
                        break;
                    case "2":
						//TODO:
                        break; 
                    case "3":
						//TODO:
                        break;                    
                }

            } while (!answer.ToUpper().Equals("X"));
        } 

    }
}
