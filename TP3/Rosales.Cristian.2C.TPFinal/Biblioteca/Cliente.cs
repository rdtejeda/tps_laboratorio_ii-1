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
        /// <summary>
        /// Constructor con Parametros. Utiliza el de la clase Base. Persona.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Cliente(int dni, string nombre, string apellido, string telefono, string mail, string patente)
                       : base(dni, nombre, apellido, telefono, mail)
        {
            this.patente = patente;
        }

        /// <summary>
        /// Override de ToString para imprimir los datos de contacto del cliente.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido:  {base.ToString()}");
            sb.AppendLine($"Telefono:           {this.Telefono}");
            sb.AppendLine($"Mail:               {this.Mail}");
            return sb.ToString();
        }

    }
}
