namespace Guia1_Unidad1.Bloque_4
{
    public class BusquedaYOrdenamiento
    {
        public BusquedaYOrdenamiento()
        {
            int[] números = new int[10];
            int i = 0;
            // Llenar arreglo con validación
            while (i < 10)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out números[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Número inválido. Intente de nuevo.");
                }
            }

            // Búsqueda lineal
            int buscar;
            Console.Write("\nIngrese un número a buscar: ");
            while (!int.TryParse(Console.ReadLine(), out buscar))
            {
                Console.Write("Ingrese un número válido: ");
            }
            bool encontrado = false;
            i = 0;
            while (i < números.Length)
            {
                if (números[i] == buscar)
                {
                    Console.WriteLine("Número encontrado en la posición: " + i);
                    encontrado = true;
                    break;
                }
                i++;
            }
            if (!encontrado)
            {
                Console.WriteLine("Número no encontrado en el arreglo.");
            }

            // Encontrar el segundo mayor
            int mayor = int.MinValue;
            int segundoMayor = int.MinValue;
            i = 0;
            while (i < números.Length)
            {
                if (números[i] > mayor)
                {
                    segundoMayor = mayor;
                    mayor = números[i];
                }
                else
                {
                    if (números[i] > segundoMayor && números[i] != mayor)
                    {
                        segundoMayor = números[i];
                    }
                    i++; 
                }
            }
            Console.WriteLine("El segundo mayor número es: " + segundoMayor);
            
            // Ordenamiento burbuja ascendente
            int n = números.Length;
            int j;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (números[j] > números[j + 1])
                    {
                        int temp = números[j];
                        números[j] = números[j + 1];
                        números[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nArreglo colocado de forma ascendente:");
            i = 0;
            while (i < n)
            {
                Console.Write(números[i] + " ");
                i++;
            }
            Console.WriteLine();
            
            // Mostrar elementos en posiciones pares
            Console.WriteLine("\nElementos en posiciones pares:");
            i = 0;
            while (i < n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Posición " + i + ": " + números[i]);
                    i++;
                }
            }
        }
    }
}