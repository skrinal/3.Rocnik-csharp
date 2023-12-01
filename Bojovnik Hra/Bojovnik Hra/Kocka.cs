using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojovnik_Hra
{
        class Kocka
        {
            private Random random;
            private int pocetSten;

            public Kocka()
            {
                pocetSten = 6;
                random = new Random();
            }

            public Kocka(int pocetSten)
            {
                this.pocetSten = pocetSten;
                random = new Random();
            }

            public int VratPocetSten()
            {
                return pocetSten;
            }

            public int hod()
            {
                return random.Next(1, pocetSten + 1);
            }

            public override string ToString()
            {
                return String.Format("Kostka s {0} stěnami", pocetSten);
            }

        }
    }
