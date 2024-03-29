﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Consructor con parametros SUV, utiliza el constructor con parametros de VEHICULO (base class)
        /// </summary>
        /// <param name="marca">Base: Marca del SUV</param>
        /// <param name="chasis">Base: Chasis del SUV</param>
        /// <param name="color">Base: Color del SUV</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
                    : base(chasis, marca, color)
        {

        }

        /// <summary>
        /// Propiedad Tamanio: SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Metodo Mostrar SUV
        /// </summary>
        /// <returns>Devuelve STRING con Tipo de Vehiculo y los atributos del objeto</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
