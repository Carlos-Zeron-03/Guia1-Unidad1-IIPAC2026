namespace Guia1_Unidad1.Bloque_3
{
    public class PatronAsteriscos
    {
        public PatronAsteriscos()
        {
            Console.WriteLine("\n--- MENÚ DE PATRONES ---");
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Ingrese el tamaño: ");
            int n = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: // Triángulo
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                break;

                case 2: // Triángulo invertido
                    for (int i = n; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                break;

                case 3: // Rombo
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = i; j < n; j++)
                            {
                                Console.Write(" ");
                            }

                        for (int j = 1; j <= (2 * i - 1); j++)
                            {
                                Console.Write("*");
                            }
                        Console.WriteLine();
                    }
                    for (int i = n - 1; i >= 1; i--)
                    {
                        for (int j = n; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i - 1); j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                break;

                case 4: // Cuadrado hueco
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine();
                    }
                break;

                default: Console.WriteLine("Opción no válida.");
                break;
        }
        }
    }
}