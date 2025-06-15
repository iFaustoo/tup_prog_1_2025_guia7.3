using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            double promedio;
            int contador = 0, acumulador = 0;

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("Ingrese un número");
                numero = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + numero;
                contador++;
            }

            promedio = acumulador / contador;

            Console.WriteLine($"El promedio de los 20 números ingresados es: {promedio}");

        }
    }
}
