using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia1_Unidad1.Bloque_1
{
    public class DesgloseBilletes
    {
        public DesgloseBilletes()
        {
            int monto;
            Console.Write("Ingrese el monto en lempiras: ");
            while (!int.TryParse(Console.ReadLine(), out monto) || monto < 0)
                {
                    Console.Write("Monto inválido. Ingrese un número positivo: ");
                }
            int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("\nDesglose de billetes:");
            for (int i = 0; i < billetes.Length; i++)
                {
                    int cantidad = monto / billetes[i];
                    if (cantidad > 0)
                        {
                            Console.WriteLine("Billetes de " + billetes[i], " :" + cantidad, "L.");
                            monto %= billetes[i];
                        }
                }
            Console.WriteLine("\nFin del proceso.");
        }
    }
}