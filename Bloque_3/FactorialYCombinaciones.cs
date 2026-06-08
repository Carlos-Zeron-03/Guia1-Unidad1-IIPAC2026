namespace Guia1_Unidad1.Bloque_3
{
    public class FactorialYCombinaciones
    {
        public FactorialYCombinaciones()
        {
            int n, r;
            Console.Write("Ingrese el valor de n: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Entrada inválida. Ingrese un número entero positivo: ");
            }

            Console.Write("Ingrese el valor de r: ");
            while (!int.TryParse(Console.ReadLine(), out r) || r < 0 || r > n)
            {
                Console.Write("Entrada inválida. r debe ser >= 0 y <= n: ");
            }

            long factorialN = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            long factorialR = 1;
            for (int i = 1; i <= r; i++)
            {
                factorialR *= i;
            }

            long factorialNR = 1;
            for (int i = 1; i <= (n - r); i++)
            {
                factorialNR *= i;
            }

            long combinación = factorialN / (factorialR * factorialNR);
            Console.WriteLine("\nEl factorial de " + n + " (n!) es: " + factorialN);
            Console.WriteLine("La combinación C " + n + "," + r + " es: " + combinación);
        }
    }
}