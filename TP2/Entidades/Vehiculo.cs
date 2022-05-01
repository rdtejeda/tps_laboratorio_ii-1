using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        
        private string chasis;
        private EMarca marca;
        private ConsoleColor color;

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="chasis">Chasis del Vehiculo</param>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="color">Color del Vehiculo</param>
        protected Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return ((string)this);
        }

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine("CHASIS: ");// {0}\r\n");
            //sb.AppendLine(p.chasis);
            //sb.AppendLine("MARCA : ");// {0}\r\n");
            //sb.AppendLine(p.marca.ToString());
            //sb.AppendLine("COLOR : ");// {0}\r\n");
            //sb.AppendLine(p.color.ToString());
            //sb.AppendLine("---------------------");
            sb.AppendLine("CHASIS: "+ p.chasis);
            sb.AppendLine("MARCA : "+ p.marca.ToString());
            sb.AppendLine("COLOR : "+ p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Vehiculo a comparar</param>
        /// <param name="v2">Vehiculo a comparar</param>
        /// <returns>True si son el mismo vehiculo comparando los chasis. False si no.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Vehiculo a Comparar</param>
        /// <param name="v2">Vehiculo a Comparar</param>
        /// <returns>False si son iguales, True si son distintos</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }
}
