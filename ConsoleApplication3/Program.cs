using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("MariuszTomasz","LewandowskiMajkowski");
            Autor Jacek = new Autor("WIesław", "Dudek", "Polska");
            List<Czasopismo> Lista1 = new List<Czasopismo>();
            Lista1.Add(new Czasopismo(1, "Władca", "Nowa Era", 1742, 1));
            Lista1.Add(new Czasopismo(2, "Władek", "Nowa Era", 1932, 6));
            Lista1.Add(new Czasopismo(3, "Wow", "Nowa Era", 1953, 5));
            Lista1.Add(new Czasopismo(4, "Jcek", "Nowa Era", 1192, 4));
            Lista1.Add(new Czasopismo(5, "Wławd", "Nowa Era", 1392, 3));
            Lista1.Add(new Czasopismo(6, "Włdcaasfaf", "Nowa Era", 1932, 2));

            
            
              
            

            Console.ReadKey();
        }
    }
}
