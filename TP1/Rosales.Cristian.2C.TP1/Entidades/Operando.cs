using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Operando
    {
        private double numero;

        /// <summary>
        /// Propiedad Set para el atributo número; valida el valor ingresado.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {

        }

        /// <summary>
        /// Constructor sin parámetros, setea el valor por defecto en CERO.
        /// </summary>
        public Operando() :this(0)
        {

        }

        /// <summary>
        /// Consrtuctor con Parámetro (recibe DOUBLE)
        /// </summary>
        /// <param name="numero">Valor a inicializar en el atributo NUMERO de la clase</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Consrtuctor con Parámetro (recibe STRING y usa la propiedad Set Numero)
        /// </summary>
        /// <param name="strNumero">Valor a ingresar al atributo numero de la clase</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Operador RESTA
        /// </summary>
        /// <param name="n1">Numero 1: Tipo OPERANDO</param>
        /// <param name="n2">Numero 2: Tipo OPERANDO</param>
        /// <returns>Devuelve resultado RESTA: Tipo DOUBLE</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double resultado = double.MinValue;

        }

        /// <summary>
        /// Operador MULTIPLICACION
        /// </summary>
        /// <param name="n1">Numero 1: Tipo OPERANDO</param>
        /// <param name="n2">Numero 2: Tipo OPERANDO</param>
        /// <returns>Devuelve resultado PRODUCTO: Tipo DOUBLE</returns>
        public static double operator *(Operando n1, Operando n2)
        {

        }

        /// <summary>
        /// Operador DIVISION
        /// </summary>
        /// <param name="n1">Numero 1: Tipo OPERANDO</param>
        /// <param name="n2">Numero 2: Tipo OPERANDO</param>
        /// <returns>Devuelve resultado COCIENTE: Tipo DOUBLE</returns>
        public static double operator /(Operando n1, Operando n2)
        {

        }

        /// <summary>
        /// Operador SUMA
        /// </summary>
        /// <param name="n1">Numero 1: Tipo OPERANDO</param>
        /// <param name="n2">Numero 2: Tipo OPERANDO</param>
        /// <returns>Devuelve resultado SUMA: Tipo DOUBLE</returns>
        public static double operator +(Operando n1, Operando n2)
        {

        }

        /// <summary>
        /// Valida que el argumento recibido sea numérico.
        /// </summary>
        /// <param name="strNumero">String a validar</param>
        /// <returns>Devuelve el DOUBLE ingresado si strNumero es numérico, caso contrario devuelve 0.</returns>
        private static double ValidarOperando(string strNumero)
        {
            double operadorValido;
            if(!double.TryParse(strNumero, out operadorValido))
            {
                operadorValido = 0;
            }
            return operadorValido;
        }

    }
}
