using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace rubros
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int g1=1, g2=2, g3=3, g4=4;
            double a1 = 0, a2 = 0, a3 = 0, a4 = 0;
            int valores;
            double promedio1=0, promedio2=0, promedio3=0, promedio4=0;
            double mayorPromedio, grupoMayorPromedio, menorPromedio, grupoMenorPromedio;
            int contador = 0;

            Console.WriteLine("Ingrese los valores del grupo 1");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Valor " + i);
                g1 = Convert.ToInt32(Console.ReadLine());
                a1 = a1 + g1;
                contador++;
            }
            Console.WriteLine("Ingrese los valores del grupo 2");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Valor " + i);
                g2 = Convert.ToInt32(Console.ReadLine());
                a2 = a2 + g2;
                contador++;
            }
            Console.WriteLine("Ingrese los valores del grupo 3");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Valor " + i);
                g3 = Convert.ToInt32(Console.ReadLine());
                a3 = a3 + g3;
                contador++;
            }
            Console.WriteLine("Ingrese los valores del grupo 4");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Valor " + i);
                g4 = Convert.ToInt32(Console.ReadLine());
                a4 = a4 + g4;
                contador++;
            }

            promedio1 = a1 / 6;
            promedio2 = a2 / 6;
            promedio3 = a3 / 6;
            promedio4 = a4 / 6;

            Console.WriteLine($"Promedio del grupo 1: {promedio1}");
            Console.WriteLine($"Promedio del grupo 2: {promedio2}");
            Console.WriteLine($"Promedio del grupo 3: {promedio3}");
            Console.WriteLine($"Promedio del grupo 4: {promedio4}");

            mayorPromedio = promedio1;
            menorPromedio = promedio1;

            if (promedio2 > mayorPromedio)
            {
                mayorPromedio = promedio2;
            }
            else if (promedio3 > mayorPromedio)
            {
                mayorPromedio = promedio3;
            }
            else if (promedio4 > mayorPromedio)
            {
                mayorPromedio = promedio4;
            }

            if (promedio2 < menorPromedio)
            {
                menorPromedio = promedio2;
            }
            else if (promedio3 < menorPromedio)
            {
                menorPromedio = promedio3;
            }
            else if (promedio4 < menorPromedio)
            {
                menorPromedio = promedio4;
            }


            grupoMayorPromedio = mayorPromedio;
            grupoMenorPromedio = menorPromedio;


            mayorPromedio = promedio1;
            menorPromedio = promedio1;
            grupoMayorPromedio = 1;
            grupoMenorPromedio = 1;

            if (promedio2 > mayorPromedio)
            {
                mayorPromedio = promedio2;
                grupoMayorPromedio = 2;
            }
            if (promedio3 > mayorPromedio)
            {
                mayorPromedio = promedio3;
                grupoMayorPromedio = 3;
            }
            if (promedio4 > mayorPromedio)
            {
                mayorPromedio = promedio4;
                grupoMayorPromedio = 4;
            }

            if (promedio2 < menorPromedio)
            {
                menorPromedio = promedio2;
                grupoMenorPromedio = 2;
            }
            if (promedio3 < menorPromedio)
            {
                menorPromedio = promedio3;
                grupoMenorPromedio = 3;
            }
            if (promedio4 < menorPromedio)
            {
                menorPromedio = promedio4;
                grupoMenorPromedio = 4;
            }


            Console.WriteLine($"El promedio es {mayorPromedio} siendo este del grupo {grupoMayorPromedio}");
            Console.WriteLine($"El menor promedio es {menorPromedio} siendo este del grupo {grupoMenorPromedio}");
            Console.WriteLine("<3");
            
        }
    }
}
