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
            Console.WriteLine("Bojovníci: \n");
            VypisBojovnika(bojovnik1);
            Console.WriteLine();
            VypisBojovnika(bojovnik2);
            Console.WriteLine();
        }

        private void VypisBojovnika(Bojovnik b)
        {
            Console.WriteLine(b);
            Console.Write("Život: ");
            Console.WriteLine(b.GrafickyZivot());
            if (b is Mag)
            {
                Console.Write("Mana: ");
                Console.WriteLine(((Mag)b).GrafickaMana());
            }
        }

        private void VypisSpravy(string sprava)
        {
            Console.WriteLine(sprava);
            Thread.Sleep(500);
        }

        public void Zapas()
        {
            Bojovnik b1 = bojovnik1;
            Bojovnik b2 = bojovnik2;

            Console.WriteLine("Vitajte v Arene!");
            Console.WriteLine($"Dnes se utkaju {bojovnik1} s {bojovnik2}! \n");

            bool zacinaBojovnik2 = (kocka.hod() <= kocka.VratPocetSten() / 2);
            if (zacinaBojovnik2)
            {
                b1 = bojovnik2;
                b2 = bojovnik1;
            }

            Console.WriteLine("Začínat bude bojovník {0}! \nZápas može začat...", b1);
            Console.ReadKey();


            // cyklus z bojem
            while (b1.Nazive() && b2.Nazive())
            {
                Vykresli();
                Thread.Sleep(500);
                b1.Utok(b2);
                Vykresli();
                VypisSpravy(b1.VratPosldnuSpravu()); // zpráva o útoku
                VypisSpravy(b2.VratPosldnuSpravu()); // zpráva o obraně
                if (b2.Nazive())
                {
                    b2.Utok(b1);
                    Vykresli();
                    VypisSpravy(b2.VratPosldnuSpravu()); // zpráva o útoku
                    VypisSpravy(b1.VratPosldnuSpravu()); // zpráva o obraně
                }
            Console.WriteLine();
            }
        }
    }

}
