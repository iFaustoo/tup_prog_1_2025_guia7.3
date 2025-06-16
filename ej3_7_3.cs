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

            bool continuar = true;
            int nMenor = -1, nMayor = -1, n;
            int posicion = 0, posicionMayor = 0, posicionMenor = 0;


            Console.WriteLine("Ingrese un número (0-100)");
            n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n <= 100)
            {

                posicion++;
                nMayor = n;
                nMenor = n;
                posicionMenor = posicion;
                posicionMayor = posicion;
                

                do
                {
                    Console.WriteLine("Desea volver a ingresar otro número? s/n");
                    string respuesta = Console.ReadLine();
                    if (respuesta == "s")
                    {
                        Console.WriteLine("Ingrese un número (0-100)");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n >= 0 && n <= 100)
                        {
                            posicion++;
                            if (n > nMayor)
                            {
                                nMayor = n;
                                posicionMayor = posicion;
                            }
                            else if (n < nMenor)
                            {
                                nMenor = n;
                                posicionMenor = posicion;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Porfavor ingrese un número entre 0 y 100");
                        }
                        

                    }
                    else
                    {
                        Console.WriteLine($"El mayor número ingresado fue {nMayor} y el menor número ingresado fue {nMenor}");
                        Console.WriteLine($"El {nMayor} fue ingresado en la posición {posicionMayor}");
                        Console.WriteLine($"El {nMenor} fue ingresado en la posicion {posicionMenor}");
                        continuar = false;
                    }




            } while (continuar == true);
            }   
            else
            {
                Console.WriteLine("Porfavor, ingrese un número entre 0 y 100");
            }
                

        }
    }
}
