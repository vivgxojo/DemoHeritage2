using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage2
{
    /// <summary>
    /// Interface spécifiant un document dans une bilbliothèque
    /// et définissant qu'on doit pouvoir le retirer.
    /// </summary>
    public class IDocument
    {
        /// <summary>
        /// Titre du document
        /// </summary>
        public string Titre { get; set; }

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
        public bool Retirer() {  return true; }

    }
}
