using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia1_Unidad1.Bloque_1
{
    public class CalculoSalarioSemanal
    {
        public CalculoSalarioSemanal()
        {
            double horas, tarifa;

            // Validar primero las horas
            do
            {
                Console.Write("Ingrese horas trabajadas: ");
                horas = Convert.ToDouble(Console.ReadLine());
                if (horas < 0)
                {
                    Console.WriteLine("Error: Las horas no pueden ser negativas.");                            
                }
            } while (horas < 0);

            // Validar la tarifa por hora
            do
            {
                Console.Write("Ingrese tarifa por hora: ");
                tarifa = Convert.ToDouble(Console.ReadLine());
                if (tarifa <= 0)
                {
                    Console.WriteLine("Error: La tarifa debe ser mayor que cero.");
                }
            } while (tarifa <= 0);
            double horasNormales = 0;
            double horasExtras = 0;
            if (horas > 44)
            {
                horasNormales = 44;
                horasExtras = horas - 44;
            }
            else
            {
                horasNormales = horas;
            }
            double pagoNormal = horasNormales * tarifa;
            double pagoExtra = horasExtras * tarifa * 1.5;
            double total = pagoNormal + pagoExtra;

            Console.WriteLine("\n------ Tarifa Final ------\n");
            Console.WriteLine("Horas normales: "+ horasNormales);
            Console.WriteLine($"Pago normal: {pagoNormal:F2}"); // Se coloca asi para que solo salgan dos números después del punto
            Console.WriteLine("Horas extras: " + horasExtras);
            Console.WriteLine($"Pago extra (150%): {pagoExtra:F2}");
            Console.WriteLine($"Total a pagar: {total:F2}");
        }
    }
}