using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simeticNikNasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik();
            u1.Ime = "Marko";
            u1.Prezime = "Marulić";
            u1.Razred = 3;

            Nastavnik n1 = new Nastavnik();
            n1.Ime = "MrKee";
            n1.Prezime = "ItMaster";
            n1.Predmet = "Programiranje";

            Console.WriteLine(u1.ToString());

            Console.WriteLine(n1.DohvatiPodatke());

            Console.ReadKey();
        }
    }
}
