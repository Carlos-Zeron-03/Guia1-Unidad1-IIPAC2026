namespace Guia1_Unidad1.Bloque_2
{
    public class ClasificacionDeTriangulos
    {
        public ClasificacionDeTriangulos()
        {
            double a, b, c;

            // Validar lado A
            do
            {
                Console.Write("Ingrese lado A: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("Error: El valor debe ser positivo.");
                }
            } while (a <= 0);

            // Validar lado B
            do
            {
                Console.Write("Ingrese lado B: ");
                b = Convert.ToDouble(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("Error: El valor debe ser positivo.");
                }
            } while (b <= 0);

            // Validar lado C
            do
            {
                Console.Write("Ingrese lado C: ");
                c = Convert.ToDouble(Console.ReadLine());
                if (c <= 0)
                {
                    Console.WriteLine("Error: El valor debe ser positivo.");
                }
            } while (c <= 0);

            // Verificar desigualdad triangular
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("\nEs un triangulo valido.");

                // Clasificación por lados
                if (a == b && b == c)
                {
                    Console.WriteLine("Tipo de triangulo por sus lados: Equilátero");
                }
                else
                if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Tipo de triangulo por sus lados: Isosceles");
                }
                else
                {
                    Console.WriteLine("Tipo por lados: Escaleno");
                }

                // Clasificación por ángulos
                double a2 = a * a;
                double b2 = b * b;
                double c2 = c * c;
                double mayor = Math.Max(a, Math.Max(b, c));
                double sumaCuadrados;
                double mayorCuadrado = mayor * mayor;
                if (mayor == a)
                {
                    sumaCuadrados = b2 + c2;
                }
                else
                {
                    if (mayor == b)
                    {
                        sumaCuadrados = a2 + c2;
                    }
                    else
                    {
                        sumaCuadrados = a2 + b2;
                    }    
                }
                if (mayorCuadrado == sumaCuadrados)
                {
                    Console.WriteLine("Tipo de triangulo por sus ángulos: Rectángulo");
                }
                else
                {
                    if (mayorCuadrado < sumaCuadrados)
                    {
                        Console.WriteLine("Tipo de triangulo por sus ángulos: Acutángulo");
                    }
                    else
                    {
                        Console.WriteLine("Tipo de triangulo por sus ángulos: Obtusángulo");
                    }                                    
                }
            }
            else
            {
                Console.WriteLine("\nNo forman un triángulo válido.");
            }
        }
    }
}