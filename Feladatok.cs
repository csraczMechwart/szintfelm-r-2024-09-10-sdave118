using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Foci
{
    internal class Feladatok
    {
        List<FociAdatok> adatok = new List<FociAdatok>();
        public string eltaroltCsapatnev = "";

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

        public void Feladat4()
        {
            bool flag = true;

            Console.WriteLine("4. Feladat");

            while (flag)
            {
                Console.Write("Csapatnev: ");
                string csapatNev = Console.ReadLine();
                foreach (var item in adatok)
                {
                    if (item.HazaiCsapatNev.ToLower() == csapatNev.ToLower() || item.VendegCsapatNev.ToLower() == csapatNev.ToLower())
                    {
                        eltaroltCsapatnev = csapatNev;
                        flag = false;
                        return;
                    }
                }
                Console.WriteLine("Nincs ilyen csapatnev");
            }


        }

        public void Feladat5()
        {
            Console.WriteLine("5. Feladat");
            int lottGolok = 0, kapottGolok = 0;

            foreach (var item in adatok)
            {
                if (item.HazaiCsapatNev.ToLower() == eltaroltCsapatnev)
                {
                    lottGolok += item.HazaiGolok;
                    kapottGolok += item.VendegGolok;
                }
                else if (item.VendegCsapatNev.ToLower() == eltaroltCsapatnev)
                {
                    lottGolok += item.VendegGolok;
                    kapottGolok += item.HazaiGolok;
                }
            }

            Console.WriteLine($"lőtt: {lottGolok} kapott: {kapottGolok}");
        }

        public void Feladat6()
        {
            Console.WriteLine("6. Feladat");
            var list = adatok.OrderBy(x => x.Fordulo).ToList();



            foreach (var item in list)
            {
                if (item.HazaiCsapatNev.ToLower() == eltaroltCsapatnev && item.HazaiGolok < item.VendegGolok)
                {
                    Console.WriteLine($"A csapat a(z) {item.Fordulo}. forduloban kapott ki a(z) {item.VendegCsapatNev} csapattól");
                    return;
                }
            }
            Console.WriteLine("Ez a csapat veretlen maradt");
        }
    }
}
