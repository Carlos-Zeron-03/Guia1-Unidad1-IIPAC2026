namespace Guia1_Unidad1.Bloque_4
{
    public class FrecuenciaElementos
    {
        public FrecuenciaElementos()
        {
            int[] números = new int[20];
            int[] frecuencia = new int[10]; // índices 0-9 representan números 1-10
            Random rnd = new Random();

            // Generar 20 números aleatorios entre 1 y 10
            for (int i = 0; i < 20; i++)
            {
                números[i] = rnd.Next(1, 11); // 1 a 10
            }

            // Contar frecuencia
            for (int i = 0; i < 20; i++)
            {
                frecuencia[números[i] - 1]++;
            }

            // Mostrar números generados
            Console.WriteLine("Números generados:");
            foreach (int num in números)
            {
                Console.Write(num + " ");
                Console.WriteLine("\n");
            }
                                    
            // Mostrar frecuencia de cada número
            Console.WriteLine("Frecuencia de cada número:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}: {frecuencia[i]}");
            }
            // Encontrar más y menos frecuente
            int maxFreq = frecuencia[0], minFreq = frecuencia[0];
            int numMax = 1, numMin = 1;
            for (int i = 1; i < 10; i++)
            {
                if (frecuencia[i] > maxFreq)
                {
                    maxFreq = frecuencia[i];
                    numMax = i + 1;
                }
                if (frecuencia[i] < minFreq)
                {
                    minFreq = frecuencia[i];
                    numMin = i + 1;
                }
            }

            Console.WriteLine("\nNúmero más frecuente " + numMax + ": " + maxFreq + " veces.");
            Console.WriteLine("Número menos frecuente " + numMin + ": " + minFreq + " veces.");
        }
    }
}