using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;

        public Autor autor;

        //konstruktor domyślny (warto dodać tworzenie pola autor jako obiektu Autor)
        public Ksiazka()
        {
            autor = new Autor();
        }

        //konstruktor parametryczny - warto ustawic tez autora
        public Ksiazka(string imie, string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
            : base(tytul, wydawnictwo, rokWydania,id)
        {
            this.liczbaStron = liczbaStron;
            autor = new Autor(imie, nazwisko);
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytul: {0}",tytul);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydania: {0}", rokWydania);
            Console.WriteLine("ID: {0}",id);
            Console.WriteLine("Liczba Stron: {0}", liczbaStron);
            Console.WriteLine("Autor: {0}", autor.PobierzAutora()); //warto wypisac autora

        }


    }
}
