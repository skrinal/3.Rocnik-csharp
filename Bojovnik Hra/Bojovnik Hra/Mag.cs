using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojovnik_Hra
{
    class Mag: Bojovnik
    {
        private int mana;
        private int maxMana;
        private int magickyUtok;

        public Mag(string meno, int zivot, int utok, int obrana, Kocka kocka, int mana, int magickyUtok) : base(meno, zivot, utok, obrana, kocka)
        {
            this.mana = mana;
            this.maxMana = mana;
            this.magickyUtok = magickyUtok;
        }

        public override void Utok(Bojovnik souper)
        {
            // Mana není naplněna
            if (mana < maxMana)
            {
                mana += 10;
                if (mana > maxMana)
                    mana = maxMana;
                base.Utok(souper);
            }
            else // Magický útok
            {
                int uder = magickyUtok + kocka.hod();
                NastavSpravu(String.Format("{0} použil magii za {1} hp", meno, uder));
                souper.BranSa(uder);
                mana = 0;
            }
        }

        public string GrafickaMana()
        {
            return GrafickyUkazatel(mana, maxMana);
        }
    }
}
