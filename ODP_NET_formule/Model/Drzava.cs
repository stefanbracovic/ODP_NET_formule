using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_formule.Model
{
    public class Drzava
    {
        public int Idd { get; set; }
        public string Nazivd { get; set; }

        public Drzava() { }

        public Drzava(int idd, string nazivd)
        {
            Idd = idd;
            Nazivd = nazivd;
        }

        public static string getFormatedHeader()
        {
            return string.Format("{0,-4} {1,-30}", "IDD", "NAZIVD");
        }
        public override string ToString()
        {
            return string.Format("{0,-4} {1,-30}", Idd, Nazivd);
        }
    }
}
