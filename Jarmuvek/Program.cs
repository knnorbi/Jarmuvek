using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Program
    {
        static void JarmuvekKiir(Jarmu[] jarmuvek)
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu != null) { Console.WriteLine(jarmu); }
                else { Console.WriteLine("-üres-"); }
            }
        }

        static void Main(string[] args)
        {
            Jarmu[] jarmuveink = new Jarmu[20];

            jarmuveink[0] = new Auto("ABC-123", "Lada", "Niva 4x4", Szin.Feher);
            jarmuveink[1] = new Busz("DEF-456", "Ikarus", "260", Szin.Kek, 50);

            JarmuvekKiir(jarmuveink);


            IKiberelheto eztszeretnemkiberelni = jarmuveink[0] as Auto;

            if(eztszeretnemkiberelni != null)
            {
                eztszeretnemkiberelni.Kiberel();
            }

            Console.WriteLine(jarmuveink.Count(Jarmu.SzabadEAJarmu));

            Console.ReadKey();
        }
    }
}
