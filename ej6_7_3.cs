using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rubros
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int rubro1 = 0, rubro2 = 0, rubro3 = 0, rubro4 = 0, rubro5 = 0;
            int venta1 = 0, venta2 = 0, venta3 = 0, venta4 = 0, venta5 = 0;
            int montoTotal1 = 0, montoTotal2 = 0, montoTotal3 = 0, montoTotal4 = 0, montoTotal5 = 0;
            bool continuar = true;
            int rta, rta2;
            int cantRubros = 0;
            int cantidadProductosVendidos1=0, cantidadProductosVendidos2=0, cantidadProductosVendidos3=0, cantidadProductosVendidos4=0, cantidadProductosVendidos5=0;
            double porcRubro1 = 0, porcRubro2 = 0, porcRubro3 = 0, porcRubro4 = 0, porcRubro5 = 0;
            int montoMayor = 0;

            do
            {
                Console.WriteLine("Ingrese el número de la venta");
                rta = Convert.ToInt32(Console.ReadLine());

                switch (rta)
                {
                    case 1:
                        venta1++;
                        Console.WriteLine("Ingrese el rubro del producto (1-5)");
                        rta2 = Convert.ToInt32(Console.ReadLine());
                        switch (rta2)
                        {
                            case 1:
                                rubro1++;
                                cantRubros++;
                                break;
                            case 2:
                                rubro2++;
                                cantRubros++;
                                break;
                            case 3:
                                rubro3++;
                                cantRubros++;
                                break;
                            case 4:
                                rubro4++;
                                cantRubros++;
                                break;
                            case 5:
                                rubro5++;
                                cantRubros++;
                                break;
                            default:
                                Console.WriteLine("Porfavor ingrese el número de un rubro válido (1-5)");
                                break;
                        }
                        Console.WriteLine("Ingrese la cantidad de productos vendidos");
                        cantidadProductosVendidos1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto total de la venta");
                        montoTotal1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        venta2++;
                        Console.WriteLine("Ingrese el rubro del producto (1-5)");
                        rta2 = Convert.ToInt32(Console.ReadLine());
                        switch (rta2)
                        {
                            case 1:
                                rubro1++;
                                cantRubros++;
                                break;
                            case 2:
                                rubro2++;
                                cantRubros++;
                                break;
                            case 3:
                                rubro3++;
                                cantRubros++;
                                break;
                            case 4:
                                rubro4++;
                                cantRubros++;
                                break;
                            case 5:
                                rubro5++;
                                cantRubros++;
                                break;
                            default:
                                Console.WriteLine("Porfavor ingrese el número de un rubro válido (1-5)");
                                break;
                        }
                        Console.WriteLine("Ingrese la cantidad de productos vendidos");
                        cantidadProductosVendidos2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto total de la venta");
                        montoTotal2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        venta3++;
                        Console.WriteLine("Ingrese el rubro del producto (1-5)");
                        rta2 = Convert.ToInt32(Console.ReadLine());
                        switch (rta2)
                        {
                            case 1:
                                rubro1++;
                                cantRubros++;
                                break;
                            case 2:
                                rubro2++;
                                cantRubros++;
                                break;
                            case 3:
                                rubro3++;
                                cantRubros++;
                                break;
                            case 4:
                                rubro4++;
                                cantRubros++;
                                break;
                            case 5:
                                rubro5++;
                                cantRubros++;
                                break;
                            default:
                                Console.WriteLine("Porfavor ingrese el número de un rubro válido (1-5)");
                                break;
                        }
                        Console.WriteLine("Ingrese la cantidad de productos vendidos");
                        cantidadProductosVendidos3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto total de la venta");
                        montoTotal3 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        venta4++;
                        Console.WriteLine("Ingrese el rubro del producto (1-5)");
                        rta2 = Convert.ToInt32(Console.ReadLine());
                        switch (rta2)
                        {
                            case 1:
                                rubro1++;
                                cantRubros++;
                                break;
                            case 2:
                                rubro2++;
                                cantRubros++;
                                break;
                            case 3:
                                rubro3++;
                                cantRubros++;
                                break;
                            case 4:
                                rubro4++;
                                cantRubros++;
                                break;
                            case 5:
                                rubro5++;
                                cantRubros++;
                                break;
                            default:
                                Console.WriteLine("Porfavor ingrese el número de un rubro válido (1-5)");
                                break;
                        }
                        Console.WriteLine("Ingrese la cantidad de productos vendidos");
                        cantidadProductosVendidos4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto total de la venta");
                        montoTotal4 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        venta5++;
                        Console.WriteLine("Ingrese el rubro del producto (1-5)");
                        rta2 = Convert.ToInt32(Console.ReadLine());
                        switch (rta2)
                        {
                            case 1:
                                rubro1++;
                                cantRubros++;
                                break;
                            case 2:
                                rubro2++;
                                cantRubros++;
                                break;
                            case 3:
                                rubro3++;
                                cantRubros++;
                                break;
                            case 4:
                                rubro4++;
                                cantRubros++;
                                break;
                            case 5:
                                rubro5++;
                                cantRubros++;
                                break;
                            default:
                                Console.WriteLine("Porfavor ingrese el número de un rubro válido (1-5)");
                                break;
                        }
                        Console.WriteLine("Ingrese la cantidad de productos vendidos");
                        cantidadProductosVendidos5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto total de la venta");
                        montoTotal5 = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Porfavor seleccione un número válido de venta (1-5)");
                        break;
                }
                Console.WriteLine("Desea continuar analizando? s/n");
                string rta3 = Console.ReadLine();
                if (rta3 == "s")
                {

                }
                else
                {
                    int ventasTotal = venta1 + venta2 + venta3 + venta4 + venta5;
                    porcRubro1 = rubro1 * 100 / ventasTotal;
                    porcRubro2 = rubro2 * 100 / ventasTotal;
                    porcRubro3 = rubro3 * 100 / ventasTotal;
                    porcRubro4 = rubro4 * 100 / ventasTotal;
                    porcRubro5 = rubro5 * 100 / ventasTotal;

                    if (montoTotal1 > montoMayor)
                    {
                        montoMayor = montoTotal1;
                    }
                    else if (montoTotal2 > montoMayor)
                    {
                        montoMayor = montoTotal2;
                    }
                    else if (montoTotal3 > montoMayor)
                    {
                        montoMayor = montoTotal3;
                    }
                    else if (montoTotal4 > montoMayor)
                    {
                        montoMayor = montoTotal4;
                    }
                    else if (montoTotal5 > montoMayor)
                    {
                        montoMayor = montoTotal5;
                    }
                    else
                    {

                    }

                    Console.WriteLine($"El porcentaje por rubro en cantidad del rubro 1 es {porcRubro1}%");
                    Console.WriteLine($"El porcentaje por rubro en cantidad del rubro 2 es {porcRubro2}%");
                    Console.WriteLine($"El porcentaje por rubro en cantidad del rubro 3 es {porcRubro3}%");
                    Console.WriteLine($"El porcentaje por rubro en cantidad del rubro 4 es {porcRubro4}%");
                    Console.WriteLine($"El porcentaje por rubro en cantidad del rubro 5 es {porcRubro5}%");

                    Console.WriteLine($"El monto mayor de venta es {montoMayor}$");

                    int recaudacionTotal;
                    recaudacionTotal = montoTotal1 + montoTotal2 + montoTotal3 + montoTotal4 + montoTotal5;
                    Console.WriteLine($"La recaudación total es {recaudacionTotal}");

                    continuar = false;
                }
            } while (continuar == true);



        }
    }
}
