namespace Guia1_Unidad1.Bloque_3
{
    public class NumerosPrimosEnRango
    {
        public NumerosPrimosEnRango()
        {
            Console.Write("Ingrese el inicio del rango de los números primos: ");
            // Inicia consultando el rango con el que quiere iniciar
            int inicio;
            while (!int.TryParse(Console.ReadLine(), out inicio))
            {
                Console.Write("Entrada inválida. Ingrese un número válido: ");
            }
            Console.Write("Ingrese el fin del rango de los números primos: ");
            int fin;
            while (!int.TryParse(Console.ReadLine(), out fin))
            {
                Console.Write("Entrada inválida. Ingrese un número válido: ");
            }
            
            //Ingresa hasta donde quiere calcular el numero primo
            int cantidad= 0;
            for (int i = inicio; i <= fin; i++)
            //Un ciclo for que vaya desde el datos ingresados como rango "Inicio-Fin"
            {
                int divisores = 0;
                for (int prueba = 1; prueba <= i; prueba++)
                {
                    if (i % prueba == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores == 2)
                {
                    Console.Write(i + " ");
                    cantidad++;
                    //Aumento en el contador.. +1, y aumentara hasta contar cada numero primo encontrado en el rango
                }
            }
            Console.WriteLine("\nSe encontraron un total de " + cantidad + " números primos.");
        }
    }
}