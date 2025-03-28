using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    /// <summary>
    /// Interface qui définit des objets qui peuvent être empruntés.
    /// </summary>
    public interface IEmpruntable
    {
        /// <summary>
        /// Nombre d'exemplaires de ce document
        /// </summary>
        public int NombreExemplaires { get; set; }

        /// <summary>
        /// Nombre d'exemplaires disponibles pour l'emprunt
        /// </summary>
        public int NombreDisponibles { get; set; }

        /// <summary>
        /// Méthode pour emprunter ou louer le document
        /// </summary>
        /// <returns>Vrai si le document a pu être retiré</returns>
        public bool Retirer();

        /// <summary>
        /// Méthode pour retourner le document préalablement emprunté
        /// </summary>
        /// <returns>Vrai si le document a pu être remis</returns>
        public bool Retourner();
    }
}
