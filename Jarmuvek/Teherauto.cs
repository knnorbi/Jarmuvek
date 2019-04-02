using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Teherauto : Jarmu, IMegrendelheto, IKiberelheto
    {
        int alapAr;
        int kmDij;
        bool szabad;
        int napidij;

        public Teherauto(string rendszam, string marka, string tipus, Szin szin, int alapAr, int kmDij, int napidij) : base(rendszam, marka, tipus, szin)
        {
            this.alapAr = alapAr;
            this.kmDij = kmDij;
            szabad = true;
            this.napidij = napidij; 
        }

        public int AlapAr { get { return alapAr; } }

        public int KmDij { get { return kmDij; } }

        public bool Szabad { get { return szabad; } }

        public int NapiDij { get { return napidij; } }

        public void Kiberel()
        {
            if (szabad)
            {
                szabad = false;
            }
            else
            {
                // TODO
            }
        }

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

        public int Visszaad()
        {
            if (!szabad)
            {
                szabad = true;
                return napidij; // TODO
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
