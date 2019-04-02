using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Busz : Jarmu
    {
        int ferohelyekSzama;

        public Busz(string rendszam, string marka, string tipus, Szin szin, int ferohelyekSzama) : base(rendszam, marka, tipus, szin)
        {
            this.ferohelyekSzama = ferohelyekSzama;
        }

        public int FerohelyekSzama { get { return ferohelyekSzama; } }
    }
}
