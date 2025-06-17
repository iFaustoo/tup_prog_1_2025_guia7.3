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

            int alumnos = 0;
            string nombre;
            int nLibreta = 0, nota;
            int nLibretaMayor = 0, nLibretaMenor = 0;
            int menorNota = int.MaxValue, mayorNota = int.MinValue;
            string nombreMayor = "", nombreMenor = "";
            
            Console.WriteLine("Ingrese la cantidad de alumnos");
            alumnos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número de libreta del alumno");
                nLibreta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la nota del alumno");
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota > mayorNota)
                {
                    mayorNota = nota;
                    nombreMayor = nombre;
                    nLibretaMayor = nLibreta;
                }
                if (nota < menorNota)
                {
                    menorNota = nota;
                    nombreMenor = nombre;
                    nLibretaMenor = nLibreta;
                }

            }

            Console.WriteLine($"El alumno con la mayor nota fue {nombreMayor}, número de libreta {nLibretaMayor}, con una nota total de {mayorNota}");
            Console.WriteLine($"El alumno con la menor nota fue {nombreMenor}, número de libreta {nLibretaMenor}, con una nota total de {menorNota}");

        }
    }
}
