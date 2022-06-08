using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Biblioteca
{
    public class Trabajo
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool trabajoTerminado;
        private Automovil auto;
        private bool seguro;
        private Sector sector;

        /// <summary>
        /// Prop Fecha de inicio de trabajo. ReadOnly
        /// </summary>
        public DateTime FechaInicio
        {
            get
            {
                return this.fechaInicio;
            }
        }

        /// <summary>
        /// Prop Fecha Fin. Read Only
        /// </summary>
        public DateTime FechaFin
        {
            get
            {
                return this.fechaFin;
            }
            set
            {
                this.fechaFin = value;
            }
        }

        /// <summary>
        /// Prop Trabajo Terminado. Recupera el flag y lo setea en True o Flalse.
        /// </summary>
        public bool TrabajoTerminado
        {
            get
            {
                return this.trabajoTerminado;
            }
            set
            {
                this.trabajoTerminado = value;
            }
        }

        /// <summary>
        /// Constructor con Parametros
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="cliente"></param>
        public Trabajo(DateTime fechaInicio, Automovil auto, bool seguro, Sector sector)
        {
            this.fechaInicio = fechaInicio;
            this.auto = auto;
            this.seguro = seguro;
            this.sector = sector;
            this.fechaFin = DateTime.MinValue;
        }

        /// <summary>
        /// Prop Auto. ReadOnly
        /// </summary>
        public Automovil Auto
        {
            get
            {
                return this.auto;
            }
        }

        /// <summary>
        /// Propiedad Sector.
        /// </summary>
        public Sector Sector
        {
            get
            {
                return this.sector;
            }
            set
            {
                this.sector = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha Inicio:       {this.FechaInicio}");
            sb.AppendLine($"Automovil | Marca:  {auto.Marca}");
            sb.AppendLine($"Automovil | Modelo: {auto.Modelo}");
            sb.AppendLine($"Patente:            {auto.Patente}");
            sb.AppendLine($"Sector:             {this.Sector}");
            return sb.ToString();
        }



    }
}
