using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Auto : Jarmu, IKiberelheto
    {
        int napiDij;
        bool szabad;

        public Auto(string rendszam, string marka, string tipus, Szin szin) :
            base(rendszam, marka, tipus, szin)
        {
            Random random = new Random();
            napiDij = random.Next(1000, 5000);
            szabad = true;
        }

        public int NapiDij { get { return napiDij; } }

        public bool Szabad { get { return szabad; } }

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

        public int Visszaad()
        {
            if (!szabad)
            {
                szabad = true;
                return napiDij; // TODO
            }
            else
            {
                // TODO
                return 0;
            }
        }
    }
}
