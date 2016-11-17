using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Czasopismo: Pozycja
    {
        private int numer;

        public Czasopismo() { }

        public Czasopismo(int numer, string tytul, string wydawnictwo, int rokWydania, int id)
        {
            this.numer = numer;
            this.tytul = tytul;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.id = id;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytul: {0}", tytul);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydania: {0}", rokWydania);
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Numer: {0}", numer);
          
        }
    }
}
