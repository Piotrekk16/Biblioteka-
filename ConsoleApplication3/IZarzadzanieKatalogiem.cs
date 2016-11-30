using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface IZarzadzanieKatalogiem //tu było zapętlenie, jeśli klasa ma podpięty interfejs, to interfejs nie może podpinać klasy, i słowo kluczoe interface
    {

        //tu dodajemy tylko deklarację (bez nawiasów klamrowych), przy dwóch metoda przydałyby się parametry
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int id);
        void WypiszWszystko();

    }
}
