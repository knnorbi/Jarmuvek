using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Busz : Jarmu, IMegrendelheto
    {
        int ferohelyekSzama;
        int alapAr;
        int kmDij;
        bool szabad;

        public Busz(string rendszam, string marka, string tipus, Szin szin, int ferohelyekSzama, int alapAr, int kmDij) : base(rendszam, marka, tipus, szin)
        {
            this.ferohelyekSzama = ferohelyekSzama;
            this.alapAr = alapAr;
            this.kmDij = kmDij;
            szabad = true;
        }

        public int FerohelyekSzama { get { return ferohelyekSzama; } }

        public int AlapAr { get { return alapAr; } }

        public int KmDij { get { return kmDij; } }

        public bool Szabad { get { return szabad; } }

        public int Megrendel(int km)
        {
            if (szabad)
            {
                szabad = false;
                return alapAr + km * kmDij;
            }
            else
            {
                // TODO
                return 0;
            }
        }

        public void Visszaerekezik()
        {
            if (!szabad)
            {
                szabad = true;
            }
            else
            {
                // TODO
            }
        }
    }
}
