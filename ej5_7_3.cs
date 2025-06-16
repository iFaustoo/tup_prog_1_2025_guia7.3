using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdd7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int respuesta;
            int contPos = 0, contNeg = 0, contInd = 0, contador = 0;
            bool continuar = true;
            string rta;


            do
            {

            Console.WriteLine("Usted coincide con las ideas políticas de nuestro actual presidente?");
            Console.WriteLine("0. Positivo");
            Console.WriteLine("1. Negavitvo");
            Console.WriteLine("2. Indeciso");
            respuesta = Convert.ToInt32(Console.ReadLine());

            switch (respuesta)
            {
                case 0:
                    contPos++;
                        contador++;
                    break;
                case 1:
                    contNeg++;
                        contador++;
                    break;
                case 2:
                    contInd++;
                        contador++;
                    break;
            default:
                    Console.WriteLine("Porfavor, seleccione un número válido dentro de la encuesta");
                    break;
            }
                Console.WriteLine("Desea continuar con el siguiente entrevistado? s/n");
                rta = Console.ReadLine().ToLower();
                if (rta == "s")
                {
                    Console.WriteLine("Hola");
                }
                else
                {
                    double porc0, porc1, porc2;
                    porc0 = (contPos * 100) / contador;
                    porc1 = (contNeg * 100) / contador;
                    porc2 = (contInd * 100) / contador;

                    Console.WriteLine($"El porcentaje total de personas que seleccionar la opción 0 fueron {porc0}%");
                    Console.WriteLine($"El porcentaje total de personas que seleccionar la opción 1 fueron {porc1}%");
                    Console.WriteLine($"El porcentaje total de personas que seleccionar la opción 2 fueron {porc2}%");

                    continuar = false;
                }

            } while (continuar == true);



        }
    }
}
