using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercitiul1();
            Exercitiul2();
            
        }
        public static void Exercitiul1()
        {
            Animal ruffy = new Animal("pisica", "gri", 3);
            Console.WriteLine("Proprietatile primului animal: tip= " + ruffy.TipAnimal + " culoare= " + ruffy.Culoare + " varsta= " + ruffy.Varsta);

            Animal nero = new Animal("caine", "negru cu pete");
            Console.WriteLine("Proprietatile animalului al 2-lea: tip= " + nero.TipAnimal + " culoare= " + nero.Culoare + " varsta= " + nero.Varsta);

            Animal brutus = new Animal("caine");
            Console.WriteLine("Proprietatile animalului al 3-lea: tip= " + brutus.TipAnimal + " culoare= " + brutus.Culoare + " varsta= " + brutus.Varsta);

            //Console.ReadLine();
        }

        public static void Exercitiul2()
        {
            Imobil mansion = new Imobil("casa", 3, 3000000);
            Console.WriteLine("Primul imobil este: tip = " + mansion.TipCasa + " etaje= " + mansion.NrEtaje + " pret= " + mansion.Pret + "$");

            Imobil officeBuilding = new Imobil("bloc");
            officeBuilding.NrEtaje = 10;
            officeBuilding.Pret = 10000000;
            Console.WriteLine("Al 2-lea imobil este: tip = " + officeBuilding.TipCasa + " etaje= " + officeBuilding.NrEtaje + " pret= " + officeBuilding.Pret + "$");

            Imobil ruins = new Imobil();
            ruins.TipCasa = "ruine";
            ruins.NrEtaje = 0;
            ruins.Pret = -100;
            Console.WriteLine("Al 3-lea imobil este: tip = " + ruins.TipCasa + " etaje= " + ruins.NrEtaje + " pret= " + ruins.Pret + "$");

            Console.ReadLine();
        }
    }
}
