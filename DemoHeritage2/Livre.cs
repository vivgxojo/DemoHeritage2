﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    public class Livre : IDocument
    {
        public string Titre { get ; set ; }
        public int NombreExemplaires { get; set ; }
        public int NombreDisponibles { get; set ; }

        public bool Retirer()
        {
            if (NombreDisponibles > 0)
            {
                NombreDisponibles--;
                return true;
            }
            else
                return false;
        }
    }
}
