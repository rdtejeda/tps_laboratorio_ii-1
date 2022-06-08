using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        private string patente;
        private Automovil auto;
        /// <summary>
        /// Constructor con Parametros. Utiliza el de la clase Base. Persona.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Cliente(int dni, string nombre, string apellido, string telefono, string mail, string patente, Automovil auto)
                       : base(dni, nombre, apellido, telefono, mail)
        {
            this.patente = patente;
            this.auto = auto;
        }

        /// <summary>
        /// Propiedad Auto. ReadOnly
        /// </summary>
        public Automovil Auto
        {
            get
            {
                return this.auto;
            }
            set
            {
                this.auto = value;
            }
        }

    }
}
