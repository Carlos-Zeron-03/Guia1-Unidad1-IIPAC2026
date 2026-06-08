namespace Guia1_Unidad1.Bloque_3
{
    public class SerieFibonacci
    {
        public SerieFibonacci()
        {
            Console.WriteLine("--- Serie Fibonacci ---");
            Console.Write("Cuantos números de la serie quieres ver?: ");
            int n = int.Parse(Console.ReadLine());
            
            //Validación de un numero valido, en caso que el usuario ingrese 0
            if (n <= 0)
            {
                Console.WriteLine("Ingresas un numero mayor que 0 o pa fuera");
            }
            else
            {
                long a = 0; 
                //a= numero actual
                long b = 1; 
                //b= numero siguiente
                //Long, ya que si el usuario ingresa un numero grande el int no lo va a mostrar completo
                long sumaTotal = 0;
                //contador suma inicializada en 0
                Console.WriteLine("\nSerie generada:");
                for (int i = 0; i < n; i++)
                {
                    // Muestra el valor actual de a
                    Console.Write(a + " ");
                    // vamos acumulando la suma
                    sumaTotal = sumaTotal + a;
                    // calcula el siguiente numero de la serie
                    long siguiente = a + b;
                    a = b;
                    b = siguiente;
                }
                // Double permite guardar valores decimales exactos
                double promedio = (double)sumaTotal / n;
                Console.WriteLine("\n\nSuma total: " + sumaTotal);
                Console.WriteLine("Promedio: " + promedio);
            }
        }
    }
}