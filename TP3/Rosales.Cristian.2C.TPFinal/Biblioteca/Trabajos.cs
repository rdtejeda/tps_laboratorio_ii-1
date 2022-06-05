using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Trabajos
    {
        public List<Trabajo> trabajos;
        public Sector sector;
        
        /// <summary>
        /// Constructor con Parametros. Inicializa la lista de trabajos y le asigna el sector que corresponde
        /// </summary>
        public Trabajos(Sector sector)
        {
            this.trabajos = new List<Trabajo>();
            this.sector = sector;
        }

        /// <summary>
        /// Incluyo un trabajo a la lista de trabajos
        /// </summary>
        /// <param name="trabajo"></param>
        public void AgregarTrabajo(Trabajo trabajo)
        {
            this.trabajos.Add(trabajo);
        }

        /// <summary>
        /// Prop ListaTrabajos. Devuelve una lista de trabajos.
        /// </summary>
        public List<Trabajo> ListaTrabajos
        {
            get
            {
                return this.trabajos;
            }
        }
    }
}
