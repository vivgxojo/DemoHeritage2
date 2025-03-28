using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    class Film : _Document
    {
        public decimal Cout { get; set; }

        public new bool Retirer()
        {
            if (NombreDisponibles > 0)
            {
                Console.WriteLine($"Coût de location du film : {Cout:C2}");
                NombreDisponibles--;
                return true;
            }
            else
                return false;
        }
    }
}
