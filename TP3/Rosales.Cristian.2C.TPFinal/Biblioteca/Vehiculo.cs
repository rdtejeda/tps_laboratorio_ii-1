using System;
using System.Text;

namespace Biblioteca
{
    /// <summary>
    /// Enum Color para todos los vehiculos - MUDAR AL FORM DE ATENCION Y DEPOSITO
    /// </summary>
    public enum Color
    {
        Blanco, Negro, Rojo, Azul, Gris, Verde
    }

    public abstract class Vehiculo
    {
        protected int dniCliente;
        protected string marca;
        protected string modelo;
        protected int anio;
        protected Color color;
        protected string patente;
        protected int idTrabajo;
        protected bool flagTrabajoTerminado;

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
        protected Vehiculo(int dniCliente, string marca, string modelo, int anio, Color color, string patente, int idTrabajo, bool flagTrabajoTerminado)
        {
            this.dniCliente = dniCliente;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.color = color;
            this.patente = patente;
            this.idTrabajo = idTrabajo;
            this.flagTrabajoTerminado = flagTrabajoTerminado;
        }

        /// <summary>
        /// Prop DNI Cliente. ReadOnly
        /// </summary>
        public int DniCliente
        {
            get
            {
                return this.dniCliente;
            }
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
        /// Prop Id Trabajo. ReadOnly
        /// </summary>
        public int IdTrabajo
        {
            get
            {
                return this.idTrabajo;
            }
        }

        /// <summary>
        /// Prop Flag Trabajo Terminado. ReadOnly
        /// </summary>
        public bool FlagTrabajoTerminado
        {
            get
            {
                return this.flagTrabajoTerminado;
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
            sb.AppendLine($"DNI Cliente: {this.DniCliente}");
            return sb.ToString();
        }
    }
}
