﻿namespace Foci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok feladatok = new Feladatok();

            feladatok.FileBeolvasas("meccs.txt");
            feladatok.Feladat2();
            Console.WriteLine();
            feladatok.Feladat3();
            Console.WriteLine();
            feladatok.Feladat4();
            Console.WriteLine();
            feladatok.Feladat5();
            Console.WriteLine();
            feladatok.Feladat6();

            Console.ReadKey();
        }
    }
}
