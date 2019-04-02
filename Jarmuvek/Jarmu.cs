using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    abstract class Jarmu
    {
        string rendszam;
        string marka;
        string tipus;
        Szin szin;

        public Jarmu(string rendszam, string marka, string tipus, Szin szin)
        {
            this.rendszam = rendszam;
            this.marka = marka;
            this.tipus = tipus;
            this.szin = szin;
        }

        public override string ToString()
        {
            return rendszam;
        }

        static public bool SzabadEAJarmu(Jarmu jarmu)
        {
            ISzabad kiberelheto = jarmu as ISzabad;
            if(kiberelheto == null)
            {
                return false;
            }
            else
            {
                return kiberelheto.Szabad;
            }
        }
    }
}
