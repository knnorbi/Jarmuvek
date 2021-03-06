﻿using System;
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
            jarmuveink[1] = new Busz("DEF-456", "Ikarus", "260", Szin.Kek, 50, 5000, 200);
            jarmuveink[2] = new Teherauto("NORBI-1", "IFA", "L60", Szin.Sarga, 20000, 500, 50000);

            JarmuvekKiir(jarmuveink);


            IKiberelheto eztszeretnemkiberelni = jarmuveink[0] as Auto;

            if(eztszeretnemkiberelni != null)
            {
                eztszeretnemkiberelni.Kiberel();
            }

            IMegrendelheto eztszeretnemmegrendelni = jarmuveink[1] as Busz;
            if (eztszeretnemmegrendelni != null)
            {
                for (int i = 0; i < 2; i++)
                {
                    int ar = eztszeretnemmegrendelni.Megrendel(200);
                    string kiir = string.Format("200 km-re a busz {0} foirintba került.", ar);
                    Console.WriteLine(kiir);
                }
            }


            Console.WriteLine(jarmuveink.Count(Jarmu.SzabadEAJarmu));

            Console.ReadKey();
        }
    }
}
