using Bojovnik_Hra;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Bojovnik_Hra
{
    class Program
    {
        static void Main(string[] args)
        {

            Kocka kocka = new Kocka(10);
            Bojovnik bojovnik = new Bojovnik("Kamenistakos", 100, 20, 10, kocka);

            Console.WriteLine("Život: {0}", bojovnik.GrafickyZivot()); // test GrafickyZivot();


            Bojovnik super = new Bojovnik("Shadow", 60, 18, 15, kocka);  // Nova Super
            super.Utok(bojovnik);

            Console.WriteLine(super.VratPosldnuSpravu());
            Console.WriteLine(bojovnik.VratPosldnuSpravu());


            Console.WriteLine("Život: {0}", bojovnik.GrafickyZivot());

            Console.ReadKey();

        }
    }
}
