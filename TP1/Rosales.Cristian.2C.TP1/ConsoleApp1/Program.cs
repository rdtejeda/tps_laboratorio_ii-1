using System;
using Entidades;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ingresoDecimal;
            string ingresoBinario;
            string binario;
            double nroDecimal;

            Console.WriteLine("Ingrese un Decimal:");
            double.TryParse(Console.ReadLine(), out ingresoDecimal);
            binario = Operando.DecimalBinario(ingresoDecimal);
            Console.WriteLine($"El resultado en Binario es {binario}");

            Console.WriteLine("Ingrese un Binario:");
            ingresoBinario = Console.ReadLine();
            double.TryParse(Operando.BinarioDecimal(ingresoBinario),out nroDecimal);
            Console.WriteLine($"El resultado en Decimal es {nroDecimal}");

            Console.ReadKey();
        }
    }
}
