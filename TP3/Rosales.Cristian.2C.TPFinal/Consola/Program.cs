using System;
using Biblioteca;
using System.Text;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "STYLO CAR | CRISTIAN ROSALES 2C";
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            
            Console.WriteLine($"ELEGI UNA OPCION: {fecha}");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"1) Ingreso AUTO");
            sb.AppendLine($"2) Egreso AUTO");
            sb.AppendLine($"3) Deposito");
            sb.AppendLine($"4) Empleados");
            Console.WriteLine(sb.ToString());

            int respuesta;
            int.TryParse(Console.ReadLine(), out respuesta);

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("AM de AUTO");

                    break;
                case 2:
                    Console.WriteLine("B DE AUTO");
                    break;
                case 3:
                    Console.WriteLine("ABM DEPOSITO");
                    break;
                case 4:
                    Console.WriteLine("ABM EMPLEADOS");
                    break;
            }


            Console.ReadKey();
        
        }
    }
}
