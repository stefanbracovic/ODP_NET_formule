using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_formule.UIHandler
{
    public class MainUIHandler
    {
        private readonly DrzavaUIHandler drzavaUIHandler = new DrzavaUIHandler();
        private readonly StazaUIHandler stazaUIHandler = new StazaUIHandler();
        private readonly VozacUIHandler vozacUIHandler = new VozacUIHandler();
        private readonly RezultatUIHandler rezultatUIHandler = new RezultatUIHandler();
        private readonly ComplexQueryUIHandler complexQueryUIHandler = new ComplexQueryUIHandler();

        public void HandleMainMenu()
        {
            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite opciju:");
                Console.WriteLine("1 - Rukovanje drzavama");
                Console.WriteLine("2 - Rukovanje stazama");
                Console.WriteLine("3 - Rukovanje vozacima");
                Console.WriteLine("4 - Rukovanje rezultatima");
                Console.WriteLine("5 - Kompleksni upiti");
                Console.WriteLine("X - Izlazak iz programa");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        drzavaUIHandler.HandleMenu();
                        break;
                    case "2":
                        stazaUIHandler.HandleMenu();
                        break;
                    case "3":
                        vozacUIHandler.HandleMenu();
                        break;
                    case "4":
                        rezultatUIHandler.HandleMenu();
                        break;
                    case "5":
                        complexQueryUIHandler.HandleComplexQueryMenu();
                        break;
                }

            } while (!answer.ToUpper().Equals("X"));
        }
    }
}
