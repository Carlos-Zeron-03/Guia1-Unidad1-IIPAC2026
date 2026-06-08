namespace Guia1_Unidad1.Bloque_4
{
    public class ArregloTemperaturas
    {
       public ArregloTemperaturas()
        {
            const int días = 7;
            double[] temperaturas = new double[días];
            int i = 0;

            // Ingreso de temperaturas
            while (i < días)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out temperaturas[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Valor no válido. Intente de nuevo.");
                }
            }

            // Calcular promedio
            double suma = 0;
            i = 0;
            while (i < días)
            {
                suma += temperaturas[i];
                i++;
            }
            double promedio = suma / días;
            Console.WriteLine($"\nPromedio semanal: {promedio:F2}°");

            // Mostrar días sobre el promedio
            Console.WriteLine("Días con temperatura sobre el promedio:");
            i = 0;
            while (i < días)
            {
                if (temperaturas[i] > promedio)
                {
                    Console.WriteLine($"Día {i + 1}: {temperaturas[i]}°");
                    i++;    
                }
            }

            // Encontrar día más caluroso y más frío
            double max = temperaturas[0], min = temperaturas[0];
            int diaMax = 1, diaMin = 1;
            i = 1;
            while (i < días)
            {
                if (temperaturas[i] > max)
                {
                    max = temperaturas[i];
                    diaMax = i + 1;
                }
                if (temperaturas[i] < min)
                {
                    min = temperaturas[i];
                    diaMin = i + 1;
                }
                i++;
            }
            Console.WriteLine("\nDía más caluroso: Día " + diaMax + "con " + max + " °");
            Console.WriteLine($"Día más frío: Día " + diaMin + "con " + min + " °");
        
            // Variación entre días consecutivos
            Console.WriteLine("\nVariación entre días consecutivos:");
            i = 0;
            while (i < días - 1)
            {
                double variación = temperaturas[i + 1] - temperaturas[i];
                Console.WriteLine($"Día {i + 1} → Día {i + 2}: {variación:+0.##;-0.##;0}°");
                i++;
            }
        } 
    }
}