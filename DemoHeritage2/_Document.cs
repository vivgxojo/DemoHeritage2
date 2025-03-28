using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    /// <summary>
    /// Classe abstraite spécifiant un document dans une bilbliothèque.
    /// </summary>
    public abstract class _Document : IEmpruntable
    {
        /// <summary>
        /// Titre du document
        /// </summary>
        public string Titre { get; set; }
        public int NombreExemplaires { get ; set ; }
        public int NombreDisponibles { get ; set ; }

        public virtual bool Retirer()
        {
            Console.WriteLine("Méthode virturelle dans la classe abstraite");
            NombreDisponibles--;
            return true;
        }

        public bool Retourner()
        {
            NombreDisponibles++;
            return true;
        }
    }
}
