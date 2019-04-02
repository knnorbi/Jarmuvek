using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    interface IMegrendelheto
    {
        int AlapAr { get; }
        int KmDij { get; }
        bool Szabad { get; }

        int Megrendel(int km);
        void Visszaerekezik();
    }
}
