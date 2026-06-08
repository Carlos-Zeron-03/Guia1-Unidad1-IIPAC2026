namespace Guia1_Unidad1.Bloque_4
{
    public class EstadisticasCalificaciones
    {
        public EstadisticasCalificaciones()
        {
            int n;
            // Validar cantidad de calificaciones
            Console.Write("Ingrese la cantidad de calificaciones: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Ingrese un número válido mayor que 0: ");
            }
            double[] notas = new double[n];
            int i = 0;
            // Ingreso de calificaciones con while 
            while (i < n)
            {
                Console.Write($"Ingrese la calificación #{i + 1}: ");   
                if (double.TryParse(Console.ReadLine(), out notas[i]) && notas[i] >= 0 && notas[i] <= 100)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
                }
            }
            double suma = 0;
            double max = notas[0];
            double min = notas[0];
            int aprobados = 0;
            int reprobados = 0;
            i = 0;
            // Cálculos con while
            while (i < n)
            {
                suma += notas[i];
                if (notas[i] > max)
                {
                    max = notas[i];
                }
                if (notas[i] < min)
                {
                    min = notas[i];
                }
                if (notas[i] >= 60)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
                i++;
            }
            double promedio = suma / n;
            double sumaCuadrados = 0;
            i = 0;
            while (i < n)
            {
                sumaCuadrados += Math.Pow(notas[i] - promedio, 2);
                i++;
            }
            double desviación = Math.Sqrt(sumaCuadrados / n);
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine("Máxima: " + max);
            Console.WriteLine("Mínima: " + min);
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine($"Reprobados: " + reprobados);
            Console.WriteLine($"Desviación estándar: {desviación:F2}");
        }
    }
}