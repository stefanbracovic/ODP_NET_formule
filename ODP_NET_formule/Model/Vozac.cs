using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_formule.Model
{
    public class Vozac
    {
        public int Idv { get; set; }
        public string Imev { get; set; }
        public string Prezv { get; set; }
        public int GodRodj { get; set; }
        public int BrojTit { get; set; }
        public int Drzv { get; set; }

        public Vozac() { }

        public Vozac(int idt, string imev, string prezv, int godRodj, int brojTit, int drzv)
        {
            Idv = idt;
            Imev = imev;
            Prezv = prezv;
            GodRodj = godRodj;
            BrojTit =  brojTit;
            Drzv = drzv;
        }

        public static string getFormatedHeader()
        {
            return string.Format("{0,-4} {1,-15} {2,-15} {3,-7} {4,-7} {5,-4}", "IDV", "IMEV", "PREZV", "GODRODJ", "BROJTIT", "DRZV");
        }
        public override string ToString()
        {
            return string.Format("{0,-4} {1,-15} {2,-15} {3,-7} {4,-7} {5,-4}", Idv, Imev, Prezv, GodRodj, BrojTit, Drzv);
        }

    }
}
