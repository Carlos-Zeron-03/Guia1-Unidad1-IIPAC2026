using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia1_Unidad1.Bloque_1
{
    public class AreaYPerimetro
    {
        public AreaYPerimetro()
        {
            int figura;
            do
            {
                Console.WriteLine("\n------ Menu ------\n");
                Console.Write("Seleccione una opción: \n");
                Console.WriteLine("1. Círculo\n");
                Console.WriteLine("2. Triángulo\n");
                Console.WriteLine("3. Rectángulo\n");
                Console.WriteLine("4. Trapecio\n");
                Console.WriteLine("5. Salir");
                figura = Convert.ToInt32(Console.ReadLine());
                switch (figura)
                {
                    case 1:
                    {
                        // Círculo
                        double radio = LeerPositivo("Ingrese el radio: ");
                        double areaC = Math.PI * radio * radio;
                        double perímetroC = 2 * Math.PI * radio;
                        Console.WriteLine($"Área: {areaC:F2}"); // Se coloca asi para que nos de 2 números después del punto
                        Console.WriteLine($"Perímetro: {perímetroC:F2}");
                    }
                    break;

                    case 2:
                    {
                        // Triángulo
                        double lado1 = LeerPositivo("Ingrese lado 1: ");
                        double lado2 = LeerPositivo("Ingrese lado 2: ");
                        double lado3 = LeerPositivo("Ingrese lado 3: ");
                        double altura = LeerPositivo("Ingrese la altura: ");

                        double areaT = (lado1 * altura) / 2;
                        double perímetroT = lado1 + lado2 + lado3;

                        Console.WriteLine($"Área: {areaT:F2}"); // Se coloca asi para que nos de 2 números después del punto
                        Console.WriteLine($"Perímetro: {perímetroT:F2}"); 
                    }
                    break;

                    case 3:
                    {
                        // Rectángulo
                        double baseR = LeerPositivo("Ingrese la base: ");
                        double alturaR = LeerPositivo("Ingrese la altura: ");

                        double areaR = baseR * alturaR;
                        double perímetroR = 2 * (baseR + alturaR);

                        Console.WriteLine($"Área: {areaR:F2}"); // Se coloca asi para que nos de 2 números después del punto
                        Console.WriteLine($"Perímetro: {perímetroR:F2}");                                       
                    }
                    break;

                    case 4:
                    {
                        // Trapecio
                        double baseMayor = LeerPositivo("Ingrese base mayor: ");
                        double baseMenor = LeerPositivo("Ingrese base menor: ");
                        if (baseMenor >= baseMayor)
                        {
                            Console.WriteLine("La base menor no puede ser mayor o igual a la mayor.");
                        }
                        else
                        {
                            double ladoA = LeerPositivo("Ingrese lado A: ");
                            double ladoB = LeerPositivo("Ingrese lado B: ");
                            double alturaTrap = LeerPositivo("Ingrese la altura: ");

                            double areaTrap = ((baseMayor + baseMenor) * alturaTrap) / 2;
                            double perímetroTrap = baseMayor + baseMenor + ladoA + ladoB;

                            Console.WriteLine($"Área: {areaTrap:F2}"); // Se coloca asi para que nos de 2 números después del punto
                            Console.WriteLine($"Perímetro: {perímetroTrap:F2}");     
                        }
                    }
                    break;

                    case 5:
                    {
                        Console.WriteLine("Saliendo del programa...");   
                    }
                    break;

                    default: Console.WriteLine("Opción inválida.");
                    break;
                }
            } while (figura != 5);
                        
            //Validar números positivos
            static double LeerPositivo(string mensaje)
            {
                double valor;
                do
                {
                    Console.Write(mensaje);
                    valor = Convert.ToDouble(Console.ReadLine());
                    if (valor <= 0)
                    {
                        Console.WriteLine("Error: El valor debe ser positivo.");                                  
                    }
                } while (valor <= 0);
                return valor;
            }
        }
    }
}