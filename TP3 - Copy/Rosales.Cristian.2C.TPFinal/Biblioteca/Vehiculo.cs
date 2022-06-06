using System;
using System.Text;

namespace Biblioteca
{
    /// Enum Color para todos los vehiculos - MUDAR AL FORM DE ATENCION Y DEPOSITO
    public enum Color
    {
        Blanco, Negro, Rojo, Azul, Gris, Verde
    }
    public abstract class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected int anio;
        protected Color color;
        protected string patente;

        /// <summary>
        /// Constructor con parametros, no se puede instanciar. Clase: VEHICULO
        /// </summary>
        /// <param name="dniCliente"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="anio"></param>
        /// <param name="color"></param>
        /// <param name="patente"></param>
        /// <param name="idTrabajo"></param>
        /// <param name="flagTrabajoTerminado"></param>
        protected Vehiculo(string marca, string modelo, int anio, Color color, string patente)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.color = color;
            this.patente = patente;
        }

        /// <summary>
        /// Prop Marca. ReadOnly
        /// </summary>
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        /// <summary>
        /// Prop Modelo. ReadOnly
        /// </summary>
        public string Modelo
        {
            get
            {
                return this.modelo;
            }
        }

        /// <summary>
        /// Prop Anio. ReadOnly
        /// </summary>
        public int Anio
        {
            get
            {
                return this.anio;
            }
        }

        /// <summary>
        /// Prop Color. ReadOnly
        /// </summary>
        public Color Color
        {
            get
            {
                return this.color;
            }
        }

        /// <summary>
        /// Prop Patente. ReadOnly
        /// </summary>
        public string Patente
        {
            get
            {
                return this.patente;
            }
        }

        /// <summary>
        /// Sobrecarga de ToString. Publica todos los datos del Vehículo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Modelo: {this.Modelo}");
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Anio: {this.Anio}");
            sb.AppendLine($"Color: {this.Color}");
            return sb.ToString();
        }
    }
}
