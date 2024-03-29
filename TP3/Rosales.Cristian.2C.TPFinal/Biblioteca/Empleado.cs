﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Sector
    {
        Chapa, Pintura, Lavado
    }

    public class Empleado : Persona
    {
        private Sector sector;
        private DateTime fechaIngreso;

        /// <summary>
        /// Constructor con parametros. Usa el de la clase Base.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Empleado(int dni, string nombre, string apellido, Sector sector, DateTime fechaIngreso,
                        string telefono, string mail)
                        : base(dni, nombre, apellido, telefono, mail)
        {
            this.sector = sector;
            this.fechaIngreso = fechaIngreso;
        }

        /// <summary>
        /// Prop Fecha Ingreso. ReadOnly.
        /// </summary>
        public DateTime Fechaingreso
        {
            get
            {
                return this.fechaIngreso;
            }
        }

        /// <summary>
        /// Prop Sector. Get y Set.
        /// </summary>
        public Sector GetSetSector
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
        /// Override To String. Imprime los datos del empleado y sus trabajos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Sector: {this.GetSetSector}");
            return sb.ToString();
        }

        /// <summary>
        /// Ficha Empleado RRHH. Imprime los datos propios del empleado para administracion
        /// </summary>
        /// <returns></returns>
        public string FichaEmpleadoRRHH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.ToString()}");
            sb.AppendLine($"DNI:            {this.Dni}");
            sb.AppendLine($"Sector:         {this.GetSetSector}");
            sb.AppendLine($"Fecha Ingreso:  {this.Fechaingreso}");
            sb.AppendLine($"Telefono:       {this.Telefono}");
            sb.AppendLine($"Mail:           {this.Mail}");
            return sb.ToString();
        }

    }
}
