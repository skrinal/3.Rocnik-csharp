﻿using Bojovnik_Hra;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Bojovnik_Hra
{
    class Program
    {
        static void Main(string[] args)
        {

            Kocka kocka = new Kocka(10);
            Bojovnik kamen = new Bojovnik("Kamen", 100, 20, 10, kocka);
            Bojovnik shadow = new Mag("Shadow", 60, 15, 12, kocka, 30, 45);
            Arena arena = new Arena(kamen, shadow, kocka);
            // zápas
            
            arena.Zapas();
            
            Console.ReadKey();

        }
    }
}
