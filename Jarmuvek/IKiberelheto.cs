using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    interface IKiberelheto
    {
        int NapiDij { get; }
        bool Szabad { get; }

        void Kiberel();
        int Visszaad();
    }
}
