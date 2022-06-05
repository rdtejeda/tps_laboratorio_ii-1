using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        private string sector;
        private DateTime fechaIngreso;
        private List<Trabajo> trabajosPendientes;
        private List<Trabajo> trabajosTerminados;

        /// <summary>
        /// Constructor con parametros. Usa el de la clase Base.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Empleado(int dni, string nombre, string apellido, string sector, DateTime fechaIngreso) 
                        : base(dni, nombre, apellido)
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
        /// Override To String. Imprime los datos del empleado y sus trabajos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //TERMINAR CON LA LOGICA DEL PARCIAL
            //IMPRIME EL EMPLEDAO CON TODOS SUS TRABAJOS
            return "COMPLETAR";
        }
    }
}
