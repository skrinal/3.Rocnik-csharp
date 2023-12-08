using Bojovnik_Hra;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Bojovnik_Hra
{
    class Program
    {
        static void Main(string[] args)
        {

            Kocka kostka = new Kocka(10);
            Bojovnik kamen = new Bojovnik("Kamen", 100, 20, 10, kostka);
            Bojovnik shadow = new Bojovnik("Shadow", 60, 18, 15, kostka);
            Arena arena = new Arena(kamen, shadow, kostka);
            // zápas
            
            arena.Zapas();
            
            Console.ReadKey();

        }
    }
}
