using System;
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
        private List<Trabajo> trabajosPendientes;
        private List<Trabajo> trabajosTerminados;

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
        /// Prop Fecha Ingreso. Set y Get.
        /// </summary>
        public DateTime Fechaingreso
        {
            set
            {
                this.fechaIngreso = value;
            }
            get
            {
                return this.fechaIngreso;
            }
        }

        /// <summary>
        /// Prop Trabajos Pendientes. ReadOnly
        /// </summary>
        public List<Trabajo> TrabajosPendientes
        {
            get
            {
                return this.trabajosPendientes.ToList();
            }
        }

        /// <summary>
        /// Prop Trabajos Terminados. ReadOnly
        /// </summary>
        public List <Trabajo> TrabajosTerminados
        {
            get
            {
                return this.trabajosTerminados.ToList();
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
            sb.AppendLine($"Fecha de Ingreso: {this.Fechaingreso}");
            sb.AppendLine($"Sector: {this.GetSetSector}");
            return sb.ToString();
        }
    }
}
