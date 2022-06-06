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
        //private int idTrabajo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        //private Cliente cliente;
        private bool trabajoTerminado;
        private Automovil auto;
        private bool seguro;

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
        }

        ///// <summary>
        ///// Prop Cliente. ReadOnly
        ///// </summary>
        //public Cliente Cliente
        //{
        //    get
        //    {
        //        return this.cliente;
        //    }
        //}

        //public int IdTrabajo
        //{
        //    get
        //    {
        //        return this.idTrabajo;
        //    }
        //}

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
        public Trabajo(DateTime fechaInicio, /*Cliente cliente*/Automovil auto, bool seguro)
        {
            //this.idTrabajo = IdTrabajo;
            this.fechaInicio = fechaInicio;
            this.auto = auto;
            //this.cliente = cliente;
            this.seguro = seguro;
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



    }
}
