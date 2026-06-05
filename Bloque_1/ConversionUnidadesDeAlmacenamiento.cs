namespace Guia1_Unidad1.Bloque_1
{
    public class ConversionUnidadesDeAlmacenamiento
    {
        public ConversionUnidadesDeAlmacenamiento()
        {
            int op, op1;
            double valor;
            Console.WriteLine("\n------ Menu --------");
            Console.WriteLine("\n----- Seleccione una opción -----");
            Console.WriteLine("1. Bytes");
            Console.WriteLine("2. Kilobytes (KB)");
            Console.WriteLine("3. Megabytes (MB)");
            Console.WriteLine("4. Gigabytes (GB)");
            Console.WriteLine("5. Terabytes (TB)");
            Console.Write("\nSeleccione la unidad de origen: ");
            while (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 6) // comprobar que sea una opción valida.
            {
                Console.Write("Opción incorrecta. Intente nuevamente: ");
            }

            Console.Write("\nSeleccione la unidad de destino: ");
            Console.WriteLine("\n1. Bytes");
            Console.WriteLine("2. Kilobytes (KB)");
            Console.WriteLine("3. Megabytes (MB)");
            Console.WriteLine("4. Gigabytes (GB)");
            Console.WriteLine("5. Terabytes (TB)");
            while (!int.TryParse(Console.ReadLine(), out op1) || op1 < 1 || op1 > 5) // Comprobar que la opción es valida
            {
                Console.Write("Opción incorrecta. Intente nuevamente: ");
            }
            Console.Write("Ingrese el valor a convertir: ");
            valor = Convert.ToDouble(Console.ReadLine());

            // Convertir todo primero a Bytes
            double valorEnBytes = ConvertirABytes(valor, op);

            // Convertir de Bytes a la unidad destino
            double result = ConvertirDesdeBytes(valorEnBytes, op1);
            Console.WriteLine($"\nResultado: {result:F4}");
            static double ConvertirABytes(double valor, int unidad)// Se convierte el valor primero a Bytes
            {
                switch (unidad)
                {
                    case 1: return valor; // Bytes
                    case 2: return valor * 1024; // KB
                    case 3: return valor * Math.Pow(1024, 2); // MB
                    case 4: return valor * Math.Pow(1024, 3); // GB
                    case 5: return valor * Math.Pow(1024, 4); // TB
                    default: return 0;
                }
            }
            static double ConvertirDesdeBytes(double bytes, int unidad) // Se convierte de Bytes a lo que el usuario elija
            {
                switch (unidad)
                {
                    case 1: return bytes; // Bytes
                    case 2: return bytes / 1024; // KB
                    case 3: return bytes / Math.Pow(1024, 2); // MB
                    case 4: return bytes / Math.Pow(1024, 3); // GB
                    case 5: return bytes / Math.Pow(1024, 4); // TB
                    default: return 0;
                }
            }
        }
    }
}