using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Consructor con parametros, hereda de Vehiculo (clase base)
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Base: Chasis</param>
        /// <param name="chasis">Base: Marca</param>
        /// <param name="color">Base: Color</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor con parametros que recibo el TIPO
        /// </summary>
        /// <param name="marca">Base:Marca</param>
        /// <param name="chasis">Base: Chasis</param>
        /// <param name="color">Base: Color</param>
        /// <param name="tipo">Tipo se recibe</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            :base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Propiedad Tamanio, Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Metodo Mostrar SEDAN
        /// </summary>
        /// <returns>Devuelve STRING con Tipo de Vehiculo y los atributos del objeto</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine((string)this);
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio.ToString());
            sb.AppendFormat("TIPO : {0}",this.tipo);
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
