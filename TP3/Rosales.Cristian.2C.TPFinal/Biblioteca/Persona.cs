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

        /// <summary>
        /// Constructor con Parametros.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        protected Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
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
        /// Override de ToString. Imprime todos los datos de la Persona.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {this.NombreCompleto}");
            sb.AppendLine($"DNI: {this.Dni}");
            return base.ToString();
        }
    }
}
