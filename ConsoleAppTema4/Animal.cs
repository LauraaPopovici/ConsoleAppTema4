using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema4
{
    class Animal
    {
        public Animal(string tip, string culoare, int varsta)
        {
            TipAnimal = tip;
            Culoare = culoare;
            Varsta = varsta;
        }

        public Animal(string tip)
        {
            TipAnimal = tip;
        }

        public Animal(string tip, string culoare)
        {
            TipAnimal = tip;
            Culoare = culoare;
            Varsta = 1;
        }

        public string TipAnimal { get; set; }
        public string Culoare { get; set; }
        public int Varsta { get; set; }
    }
}
