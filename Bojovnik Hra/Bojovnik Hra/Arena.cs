using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojovnik_Hra
{
    class Arena
    {
        private Bojovnik bojovnik1;
        private Bojovnik bojovnik2;
        private Kocka kocka;

        public Arena(Bojovnik bojovnik1, Bojovnik bojovnik2, Kocka kocka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kocka = kocka;
        }


        private void Vykresli()  // Stav zpasu
        {
            Console.Clear();
            Console.WriteLine("-------------- Aréna -------------- \n");
            Console.WriteLine("Zdraví bojovníků: \n");
            Console.WriteLine("{0} {1}", bojovnik1, bojovnik1.GrafickyZivot());
            Console.WriteLine("{0} {1}", bojovnik2, bojovnik2.GrafickyZivot());
        }

        private void VypisSpravy(string sprava)
        {
            Console.WriteLine(sprava);
            Thread.Sleep(500);
        }

        public void Zapas()
        {
            Console.WriteLine("Vitajte v Arene!");
            Console.WriteLine($"Dnes se utkaju {bojovnik1} s {bojovnik2}! \n");
            Console.WriteLine("Zapas moze zacat...");
            Console.ReadKey();
            
            // cyklus z bojem
            while (bojovnik1.Nazive() && bojovnik2.Nazive())
            {
                bojovnik1.Utok(bojovnik2);
                Vykresli();
                VypisSpravy(bojovnik1.VratPosldnuSpravu()); // zpráva o útoku
                VypisSpravy(bojovnik2.VratPosldnuSpravu()); // zpráva o obraně
                bojovnik2.Utok(bojovnik1);
                Vykresli();
                VypisSpravy(bojovnik2.VratPosldnuSpravu()); // zpráva o útoku
                VypisSpravy(bojovnik1.VratPosldnuSpravu()); // zpráva o obraně
                Console.WriteLine();
            }
        }
    }

}
