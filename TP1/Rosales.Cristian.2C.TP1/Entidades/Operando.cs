using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
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
        /// Convierte un string BINARIO en string DECIMAL
        /// </summary>
        /// <param name="binario">String que contiene un nro binario</param>
        /// <returns>Devuelve el valor Decimal en formato String o "Valor invalido" si no se pudo convertir</returns>
        public static string BinarioDecimal(string binario)
        {
            string nroDecimal = "Valor inválido";
            double doubleDecimal = 0;
            int caracteres = binario.Length;
            if (EsBinario(binario))
            {
                foreach(char i in binario)
                {
                    caracteres--;
                    if(i == '1')
                    {
                        doubleDecimal += Math.Pow(2, caracteres);
                    }
                }
                nroDecimal = doubleDecimal.ToString();
            }
            return nroDecimal;
        }

        /// <summary>
        /// Devuelve el valor absoluto del resultado en formato BINARIO
        /// </summary>
        /// <param name="numero">Es el resultado que se debe transformar a BINARIO</param>
        /// <returns>Devuelve el valor absoluto en BINARIO, caso contrario "Valor Inválido"</returns>
        public static string DecimalBinario(double numero)
        {
            int valorAbsoluto = (int)Math.Round(Math.Abs(numero));
            string binario = String.Empty;
            int cociente = valorAbsoluto;
            int resto;
            if (cociente >= 0)
            {
                do
                {
                    resto = cociente % 2;
                    cociente /= 2;
                    binario = resto.ToString()+binario;
                    
                } while (cociente > 0);
            }
            else
            {
                binario = "Valor Inválido";
            }
            return binario;
        }

        /// <summary>
        /// Convierte un STRING Decimal a STRING Binario
        /// </summary>
        /// <param name="numero">Numero a convertir</param>
        /// <returns>Devuelve un STRING BINARIO con el nro ingresado, o "Valor Invalido" si error.</returns>
        public static string DecimalBinario(string numero)
        {
            string decimalBinario = string.Empty;
            double convertirNumero;
            double.TryParse(numero, out convertirNumero);
            decimalBinario = DecimalBinario(convertirNumero);
            return decimalBinario;
        }

        /// <summary>
        /// Valida si el STRING recibido es un nro Binario
        /// </summary>
        /// <param name="binario">Valor a validar</param>
        /// <returns>True si es Binario, o False.</returns>
        private static bool EsBinario(string binario)
        {
            bool esBinario = true;
            foreach (char i in binario)
            {
                if (i != '0' && i != '1')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }

        /// <summary>
        /// Constructor por defecto sin parámetros, setea el valor por defecto en CERO.
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
            return n1.numero - n2.numero; ;
        }

        /// <summary>
        /// Operador MULTIPLICACION
        /// </summary>
        /// <param name="n1">Numero 1: Tipo OPERANDO</param>
        /// <param name="n2">Numero 2: Tipo OPERANDO</param>
        /// <returns>Devuelve resultado PRODUCTO: Tipo DOUBLE</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Operador DIVISION
        /// </summary>
        /// <param name="n1">Numero 1: Tipo OPERANDO</param>
        /// <param name="n2">Numero 2: Tipo OPERANDO</param>
        /// <returns>Devuelve resultado COCIENTE: Tipo DOUBLE. Division por CERO = DOUBLE.MINVALUE</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        /// <summary>
        /// Operador SUMA
        /// </summary>
        /// <param name="n1">Numero 1: Tipo OPERANDO</param>
        /// <param name="n2">Numero 2: Tipo OPERANDO</param>
        /// <returns>Devuelve resultado SUMA: Tipo DOUBLE</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Valida que el argumento recibido sea numérico.
        /// </summary>
        /// <param name="strNumero">String a validar</param>
        /// <returns>Devuelve el DOUBLE ingresado si strNumero es numérico, caso contrario devuelve 0.</returns>
        private static double ValidarOperando(string strNumero)
        {
            double operadorValido = 0;
            if(double.TryParse(strNumero, out operadorValido))
            {
                return operadorValido;
            }
            return operadorValido;
        }

    }
}
