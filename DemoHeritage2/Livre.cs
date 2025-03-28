using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    public class Livre : _Document
    {
        public override bool Retirer()
        {
            if (NombreDisponibles > 0)
            {
                return base.Retirer();
            }
            else
                return false;
        }
    }
}
