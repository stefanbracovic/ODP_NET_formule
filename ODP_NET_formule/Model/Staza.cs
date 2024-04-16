using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_formule.Model
{
    public class Staza
    {
        public string Ids { get; set; }
        public string Nazivs { get; set; }
        public int BrojKrug { get; set; }
        public int DuzKrug { get; set; }
        public int Drzs { get; set; }

        public Staza() { }

        public Staza(string ids, string nazivs, int brojKrug, int duzKrug, int drzs)
        {
            Ids = ids;
            Nazivs = nazivs;
            BrojKrug = brojKrug;
            DuzKrug = duzKrug;
            Drzs = drzs;
        }

        public static string getFormatedHeader()
        {
            return string.Format("{0,-4} {1,-20} {2,-9} {3,-7} {4,-4}", "IDS", "NAZIVS", "BROJKRUG", "DUZKRUG", "DRZS");
        }
        public override string ToString()
        {
            return string.Format("{0,-4} {1,-20} {2,-9} {3,-7} {4,-4}", Ids, Nazivs, BrojKrug, DuzKrug, Drzs);
        }

    }
}
