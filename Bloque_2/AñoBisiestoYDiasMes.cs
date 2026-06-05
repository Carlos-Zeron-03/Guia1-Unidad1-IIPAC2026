namespace Guia1_Unidad1.Bloque_2
{
    public class AñoBisiestoYDiasMes
    {
        public AñoBisiestoYDiasMes()
        {
            int año, mes;

            // Pedir el año
            Console.Write("Ingrese el año: ");
            while (!int.TryParse(Console.ReadLine(), out año) || año <= 0)
            {
                if (año <= 0)
                {
                    Console.WriteLine("Año no valido.");
                    Console.Write("Ingrese el año: ");
                }
            };
            
            // Pedir el mes
            Console.Write("Ingrese el mes (1-12): ");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                if (mes <= 0 || mes >= 13)
                {
                    Console.WriteLine("Mes no valido, tiene que ser un mes entre 1 y 12.");
                    Console.Write("Ingrese el mes (1-12): ");
                }
            };

            // Determinar si el año es bisiesto
            bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
            int días = 0;

            // Determinar los días del mes
            switch (mes)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    días = 31;
                break;

                case 4: case 6: case 9: case 11:
                    días = 30;
                break;

                case 2:
                    días = esBisiesto ? 29 : 28;
                break;
            }

            Console.WriteLine("\nAño: " + año);
            Console.WriteLine($"¿Es bisiesto?: {(esBisiesto ? "Sí" : "No")}");
            Console.WriteLine("El mes " + mes + " tiene " + días + " días.");
        }
    }
}