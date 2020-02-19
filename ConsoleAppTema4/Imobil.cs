using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema4
{
    class Imobil
    {
        public Imobil(string tip, int etaje, double pret)
        {
            TipCasa = tip;
            NrEtaje = etaje;
            Pret = pret;
        }

        public Imobil(string tip)
        {
            TipCasa = tip;
            NrEtaje = 0;
            Pret = 0;
        }

        public Imobil()
        {
            
        }

        public string TipCasa { get; set; }
        public int NrEtaje { get; set; }
        public double Pret { get; set; }

    }
}
