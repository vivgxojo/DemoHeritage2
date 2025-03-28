﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    public class Jeu : _Document
    {
        public decimal Cout {  get; set; }

        public override bool Retirer()
        {
            if (NombreDisponibles > 0)
            {
                Console.WriteLine($"Coût de location : {Cout:C2}");
                return base.Retirer();
            }
            else
                return false;
        }
    }
}
