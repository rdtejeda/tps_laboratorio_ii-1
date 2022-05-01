using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor con parametros, usa el de la clase base.
        /// </summary>
        /// <param name="marca">Base: Chasis</param>
        /// <param name="chasis">Base: Marca</param>
        /// <param name="color">Base: Color</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
                        :base(chasis,marca,color)
        {

        }
        
        /// <summary>
        /// Propiedad Tamanio: Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Metodo Mostrar CICLOMOTOR
        /// </summary>
        /// <returns>Devuelve STRING con Tipo de Vehiculo y los atributos del objeto</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
