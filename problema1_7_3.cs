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
            bool continuar = true;
            int monto = 0;
            int montoMayor = int.MinValue, montoMenor = int.MaxValue;
            string nombreMayor = "", nombreMenor = "";


            do
            {
                Console.WriteLine("Ingrese el nombre del jugador");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el monto que el jugador apostó en la ronda");
                monto = Convert.ToInt32(Console.ReadLine());

                if (monto > montoMayor)
                {
                    montoMayor = monto;
                    nombreMayor = nombre;
                }
                if (monto < montoMenor)
                {
                    montoMenor = monto;
                    nombreMenor = nombre;
                }

                Console.WriteLine("Desea agregar los datos de otro jugador? s/n");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta == "s")
                {

                }
                else
                {
                    continuar = false;
                }

            } while (continuar == true);

            Console.WriteLine($"El jugador que más apostó fue {nombreMayor} con un monto de {montoMayor}$");
            Console.WriteLine($"El jugador que menos apostó fue {nombreMenor} con un monto de {montoMenor}$");
            Console.WriteLine("<3");


        }
    }
}
