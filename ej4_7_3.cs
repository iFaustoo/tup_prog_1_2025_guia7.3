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

            int n, nMayor = 0, nMenor = int.MaxValue;



            for (int i = 1; i < 31; i++)
            {
                Console.WriteLine("Ingrese el número " + i);
                n = Convert.ToInt32(Console.ReadLine());
                if (n > nMayor)
                {
                    nMayor = n;
                }
                else if (n < nMenor)
                {
                    nMenor = n;
                }
            }
            Console.WriteLine($"El mayor número ingresado fue {nMayor}");
            Console.WriteLine($"El menor número ingresado fue {nMenor}");

        }
    }
}
