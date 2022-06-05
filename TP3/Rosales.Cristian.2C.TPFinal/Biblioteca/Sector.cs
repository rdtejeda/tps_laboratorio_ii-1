using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sector
    {
        private string nombreSector;
        private List<Empleado> empleados;
        private List<Trabajo> trabajosPendientes;
        private List<Trabajo> trabajosTerminados;

        /// <summary>
        /// Constructor con Parametros.
        /// </summary>
        /// <param name="nombreSector"></param>
        public Sector(string nombreSector)
        {
            this.nombreSector = nombreSector;
            this.empleados = new List<Empleado>();
            this.trabajosPendientes = new List<Trabajo>();
            this.trabajosTerminados = new List<Trabajo>();
        }




    }
}
