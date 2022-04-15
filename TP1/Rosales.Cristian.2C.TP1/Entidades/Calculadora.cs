using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Genera el cálculo ingresado por el usuario
        /// </summary>
        /// <param name="num1">Operando Uno: Tipo Operando</param>
        /// <param name="num2">Operando Dos: Tipo Operando</param>
        /// <param name="operador">Operador: Tipo Char</param>
        /// <returns>Devuelve el resultado: Tipo Double</returns>
        static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Método que valida si el operador ingresado es correcto (+,-,*,/)
        /// </summary>
        /// <param name="operador">Operador que se validará si es correcto</param>
        /// <returns>Si es correcto, Operador, caso contrario +</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorValido;
            switch (operador)
            {
                case '+':
                    operadorValido = operador;
                    break;
                case '-':
                    operadorValido = operador;
                    break;
                case '*':
                    operadorValido = operador;
                    break;
                case '/':
                    operadorValido = operador;
                    break;
                default:
                    operadorValido = '+';
                    break;
            }
            return operadorValido;
        }
    }
}
