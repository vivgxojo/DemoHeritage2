using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    public class Jeu : IDocument
    {
        public string Titre { get ; set ; }
        public int NombreExemplaires { get ; set; }
        public int NombreDisponibles { get; set; }

        public decimal Cout {  get; set; }

        public bool Retirer()
        {
            if (NombreDisponibles > 0)
            {
                NombreDisponibles--;
                Console.WriteLine($"Coût de location : {Cout:C2}");
                return true;
            }
            else
                return false;
        }
    }
}
