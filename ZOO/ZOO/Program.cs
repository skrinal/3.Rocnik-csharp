using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Uzivatel
    {
        protected string jmeno;
        protected string heslo;
        protected int vek;

        public bool Prihlasit(string heslo)
        {
            // ...
        }

        public bool Odhlasit()
        {
            // ...
        }

        public void NastavVahu(Zvire zvire)
        {
            // ...
        }

        // ...
    }

    class Administrator : Uzivatel
    {
        private string telefonniCislo;

        public void PridejZvire(Zvire zvire)
        {

        }

        public void VymazZvire(Zvire zvire)
        {

        }

        // ...
    }

}
