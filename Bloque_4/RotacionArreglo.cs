namespace Guia1_Unidad1.Bloque_4
{
    public class RotacionArreglo
    {
        public RotacionArreglo()
        {
            int n;
            // Ingreso del tamaño del arreglo
            Console.Write("Ingrese el tamaño del arreglo: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Número inválido. Ingrese un número mayor a 0: ");
            }
            int[] arr = new int[n];
            int i = 0;
            
            // Llenado del arreglo
            while (i < n)
            {
                Console.Write($"Ingrese el elemento #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Número inválido, no sea tonto. Intente de nuevo.");
                }
            }

            // Menú
            int opción = 0;
            while (opción != 4)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Rotar K posiciones a la izquierda");
                Console.WriteLine("2. Rotar K posiciones a la derecha");
                Console.WriteLine("3. Invertir el arreglo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opción))
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }

                switch (opción)
                {
                    case 1:
                    {
                        Console.Write("Ingrese K posiciones: ");
                        int kIzq = int.Parse(Console.ReadLine());
                        RotarIzquierda(arr, kIzq);
                        Console.WriteLine("Arreglo rotado a la izquierda:");
                        ImprimirArreglo(arr);
                    }
                    break;

                    case 2:
                    {
                        Console.Write("Ingrese K posiciones: ");
                        int kDer = int.Parse(Console.ReadLine());
                        RotarDerecha(arr, kDer);
                        Console.WriteLine("Arreglo rotado a la derecha:");
                        ImprimirArreglo(arr);
                    }
                    break;

                    case 3:
                    {
                        Array.Reverse(arr);
                        Console.WriteLine("Arreglo invertido:");
                        ImprimirArreglo(arr);
                    }
                    break;

                    case 4:
                    {
                        Console.WriteLine("Saliendo espere...");
                    }
                    break;

                    default: Console.WriteLine("Opción inválida.");
                    break;
                }
            }

            // Método para imprimir arreglo
            static void ImprimirArreglo(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                    Console.WriteLine();
                }
            }

            // Rotar a la izquierda
            static void RotarIzquierda(int[] arr, int k)
            {
                int n = arr.Length;
                k = k % n;
                int[] temp = new int[k];
                Array.Copy(arr, temp, k);
                Array.Copy(arr, k, arr, 0, n - k);
                Array.Copy(temp, 0, arr, n - k, k);
            }

            // Rotar a la derecha
            static void RotarDerecha(int[] arr, int k)
            {
                int n = arr.Length;
                k = k % n;
                int[] temp = new int[k];
                Array.Copy(arr, n - k, temp, 0, k);
                Array.Copy(arr, 0, arr, k, n - k);
                Array.Copy(temp, 0, arr, 0, k);
            }
        }
    }
}