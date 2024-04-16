using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_formule.Model
{
    public class Rezultat
    {
        public string Idr { get; set; }
        public int Vozacr { get; set; }
        public int Stazar { get; set; }
        public int Sezona { get; set; }
        public int Plasman { get; set; }
        public int Bodovi { get; set; }
        public float MaksBrzina { get; set; }

        public Rezultat() { }

        public Rezultat(string idr, int vozacr, int stazar, int sezona, int plasman, int bodovi, float maksBrzina)
        {
            Idr = idr;
            Vozacr = vozacr;
            Stazar = stazar;
            Sezona = sezona;
            Plasman = plasman;
            Bodovi = bodovi;
            MaksBrzina = maksBrzina;
        }

        public static string getFormatedHeader()
        {
            return string.Format("{0,-4} {1,-6} {2,-6} {3,-6} {4,-7} {5,-6} {6,-10}", "IDR", "VOZACR", "STAZAR", "SEZONA", "PLASMAN", "BODOVI", "MAKSBRZINA");
        }
        public override string ToString()
        {
            return string.Format("{0,-4} {1,-6} {2,-6} {3,-6} {4,-7} {5,-6} {6,-10:F2}", Idr, Vozacr, Stazar, Sezona, Plasman, Bodovi, MaksBrzina);
        }

    }
}
