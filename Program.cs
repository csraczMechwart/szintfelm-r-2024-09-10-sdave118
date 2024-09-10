namespace Foci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok feladatok = new Feladatok();

            feladatok.FileBeolvasas("meccs.txt");
            feladatok.Feladat2();

            Console.ReadKey();
        }
    }
}
