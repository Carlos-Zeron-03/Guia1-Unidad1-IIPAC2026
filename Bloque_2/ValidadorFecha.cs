namespace Guia1_Unidad1.Bloque_2
{
    public class ValidadorFecha
    {
        public ValidadorFecha()
        {
            int dia, mes, año;

            // Ingresar año
            Console.Write("Ingrese el año: ");
            while (!int.TryParse(Console.ReadLine(), out año) || año <= 0)
            {
                if (año <= 0)
                {
                    Console.WriteLine("Año no valido.");
                    Console.Write("Ingrese el año: ");
                }
            };

            // Ingresar mes
            Console.Write("Ingrese el mes (1-12): ");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                if (mes <= 0 || mes >= 13)
                {
                    Console.WriteLine("Mes no valido, tiene que ser un mes entre 1 y 12.");
                    Console.Write("Ingrese el mes (1-12): ");
                }
            };

            // Ingresar día
            Console.Write("Ingrese el día: ");
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1)
            {
                if (dia <= 0)
                {
                    Console.WriteLine("Dia no valido.");
                    Console.Write("Ingrese el día: ");
                }
            };

            // Verificar si el año es bisiesto
            bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
            int díasMes = 0;

            // Determinar días del mes
            switch (mes)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    díasMes = 31;
                break;

                case 4: case 6: case 9: case 11:
                    díasMes = 30;
                break;

                case 2:
                    díasMes = esBisiesto ? 29 : 28;
                break;
            }

            // Validar fecha
            if (dia <= díasMes)
            {
                Console.WriteLine("\nLa fecha " + dia + " " + mes + " " + año + " es válida.");
            }
            else
            {
                Console.WriteLine("\nLa fecha " + dia + " " + mes + " " + año + " NO es válida.");
            }
        }
    }
}