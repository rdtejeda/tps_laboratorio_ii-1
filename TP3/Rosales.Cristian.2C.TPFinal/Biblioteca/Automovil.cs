using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Automovil : Vehiculo
    {
        /// <summary>
        /// Enum Diagnostico para todos los trabajos de los vehiculos
        /// </summary>
        public enum Diagnostico
        {
            Microbollo, CambioParte, PinturaParte, PinturaCompleta
        }

        private Diagnostico diagnostico;

        /// <summary>
        /// Constructor con Parametros de Automovil. Usa el de la clase BASE: Vehiculo.
        /// </summary>
        /// <param name="dniCliente"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="anio"></param>
        /// <param name="color"></param>
        /// <param name="patente"></param>
        /// <param name="idTrabajo"></param>
        /// <param name="flagTrabajoTerminado"></param>
        public Automovil(int dniCliente, string marca, string modelo, int                   anio, Color color, string patente, int idTrabajo,
                        bool flagTrabajoTerminado, Diagnostico diagnostico) 
                        : base  (dniCliente, marca, modelo, anio,
                                color, patente, idTrabajo, flagTrabajoTerminado)
        {
            this.diagnostico = diagnostico;
        }

        /// <summary>
        /// Prop Diagnostico. Set y Get.
        /// </summary>
        public Diagnostico PropDiagnostico
        {
            get
            {
                return this.diagnostico;
            }
            set
            {
                this.diagnostico = value;
            }
        }

        /// <summary>
        /// Override de ToString. Imprime todas las caracteristicas del automovil + diagnostico.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Diagnostico: {this.PropDiagnostico}");
            return sb.ToString();
        }
    }
}
