using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        /// <summary>
        /// Constructor con Parametros. Utiliza el de la clase Base. Persona.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Cliente(int dni, string nombre, string apellido, string telefono, string mail) 
                       : base(dni, nombre, apellido, telefono, mail)
        {

        }




    }
}
