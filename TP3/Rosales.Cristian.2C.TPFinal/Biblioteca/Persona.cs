using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected string telefono;
        protected string mail;

        /// <summary>
        /// Constructor con Parametros.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        protected Persona(int dni, string nombre, string apellido, string telefono, string mail)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
        }

        /// <summary>
        /// Prop DNI. ReadOnly
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        /// <summary>
        /// Prop Nombre Completo. ReadOnly
        /// </summary>
        public string NombreCompleto
        {
            get
            {
                return string.Format($"{this.nombre} {this.apellido}");
            }
        }

        /// <summary>
        /// Prop Telefono. ReadOnly
        /// </summary>
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
        }

        /// <summary>
        /// Prop Mail. ReadOnly
        /// </summary>
        public string Mail
        {
            get
            {
                return this.mail;
            }
        }

        /// <summary>
        /// Override de ToString. Imprime todos los datos de la Persona.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {this.NombreCompleto}");
            return base.ToString();
        }
    }
}
