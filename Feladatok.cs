﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class Feladatok
    {
        List<FociAdatok> adatok = new List<FociAdatok>();

        public void FileBeolvasas(string fileNev)
        {
            File.ReadAllLines(fileNev);

            foreach (var item in File.ReadAllLines(fileNev, Encoding.UTF8).Skip(1))
            {
                string[] resz = item.Split(" ");
                int fordulo = Convert.ToInt32(resz[0]);
                int hazaiGolok = Convert.ToInt32(resz[1]);
                int vendegGolok = Convert.ToInt32(resz[2]);
                int elsoFelidoGolok = Convert.ToInt32(resz[3]);
                int marsodikFelidoGolok = Convert.ToInt32(resz[4]);
                string hazaiCsapatNev = resz[5];
                string vendegCsapatNev = resz[6];

                FociAdatok ujMecss = new FociAdatok(fordulo, hazaiGolok, vendegGolok, elsoFelidoGolok, marsodikFelidoGolok, hazaiCsapatNev, vendegCsapatNev);
                adatok.Add(ujMecss);
            }
        }

        public void Feladat2()
        {
            Console.WriteLine("2. Feladat");
            Console.Write("Forduló Száma:");
            int forduloSzama = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            foreach (var item in adatok)
            {
                if (item.Fordulo == forduloSzama)
                {
                    Console.WriteLine($"{item.HazaiCsapatNev}-{item.VendegCsapatNev}: {item.HazaiGolok}-{item.VendegGolok} ({item.ElsoFelidoGolok}-{item.MarsodikFelidoGolok})");
                }
            }
        }
        public void Feladat3()
        {
            Console.WriteLine("3. Feladat");

            foreach (var item in adatok)
            {
                if (item.HazaiGolok > item.VendegGolok && item.ElsoFelidoGolok < item.MarsodikFelidoGolok )
                {
                    Console.WriteLine($"{item.Fordulo} {item.HazaiCsapatNev}");
                }
                else if (item.HazaiGolok < item.VendegGolok && item.ElsoFelidoGolok > item.MarsodikFelidoGolok)
                {
                    Console.WriteLine($"{item.Fordulo} {item.VendegCsapatNev}");
                }
            }
        }
    }
}
