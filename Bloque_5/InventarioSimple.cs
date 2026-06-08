namespace Guia1_Unidad1.Bloque_5
{
    public class InventarioSimple
    {
        public InventarioSimple()
        {
            const int n = 5;
            int[] códigos = new int[n];
            string[] nombres = new string[n];
            int[] cantidades = new int[n];
            double[] precios = new double[n];

            // Ingreso de productos usando while
            int i = 0;
            while (i < n)
            {
                Console.WriteLine($"\nProducto #{i + 1}:");
                Console.Write("Código: "); //Código
                while (!int.TryParse(Console.ReadLine(), out códigos[i]))
                {
                    Console.Write("Código inválido. Ingrese un número entero: ");
                }
                // Nombre
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();
                // Cantidad
                Console.Write("Cantidad: ");
                while (!int.TryParse(Console.ReadLine(), out cantidades[i]) || cantidades[i] < 0)
                {
                    Console.Write("Cantidad inválida. Ingrese un número entero mayor o igual a 0: ");
                }
                // Precio
                Console.Write("Precio: ");
                while (!double.TryParse(Console.ReadLine(), out precios[i]) || precios[i] < 0)
                {
                    Console.Write("Precio inválido. Ingrese un número mayor o igual a 0: ");
                }
                i++;
            }
            int opción = 0;
            // Menú principal usando while
            while (opción != 5)
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. Buscar producto por código");
                Console.WriteLine("3. Actualizar cantidad de producto");
                Console.WriteLine("4. Calcular valor total del inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opción))
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }
                if (opción == 1)
                {
                    Console.WriteLine("\n--- Inventario ---");
                    i = 0;
                    while (i < n)
                    {
                        Console.WriteLine($"Código: {códigos[i]}, Nombre: {nombres[i]}, Cantidad: {cantidades[i]}, Precio: {precios[i]:C2}");
                        i++;
                    }
                }
                else
                {
                    if (opción == 2)
                    {
                        Console.Write("Ingrese el código del producto a buscar: ");
                        int códigoBuscar;
                        while (!int.TryParse(Console.ReadLine(), out códigoBuscar))
                        { 
                            Console.Write("Código inválido. Ingrese un número entero: ");
                        }
                        bool encontrado = false;
                        i = 0;
                        while (i < n)
                        {
                            if (códigos[i] == códigoBuscar)
                            {
                                Console.WriteLine($"Producto encontrado: Código: {códigos[i]}, Nombre: {nombres[i]}, Cantidad: {cantidades[i]}, Precio: {precios[i]:C2}");
                                encontrado = true;
                                break;
                            }
                            i++;
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                    }
                    else
                    {
                        if (opción == 3)
                        {
                            Console.Write("Ingrese el código del producto a actualizar: ");
                            int códigoActualizar;
                            while (!int.TryParse(Console.ReadLine(), out códigoActualizar))
                            {
                                Console.Write("Código inválido. Ingrese un número entero: ");
                            }
                            bool encontrado = false;
                            i = 0;
                            while (i < n)
                            {
                                if (códigos[i] == códigoActualizar)
                                {
                                    Console.Write($"Cantidad actual: {cantidades[i]}. Ingrese nueva cantidad: ");
                                    while (!int.TryParse(Console.ReadLine(), out cantidades[i]) || cantidades[i] < 0)
                                    {
                                        Console.Write("Cantidad inválida. Ingrese un número entero mayor o igual a 0: ");
                                    }
                                    Console.WriteLine("Cantidad actualizada.");
                                    encontrado = true;
                                    break;
                                }
                                i++;
                            }
                            if (!encontrado)
                            {
                                Console.WriteLine("Producto no encontrado.");   
                            }
                        }
                        else
                        {
                            if (opción == 4)
                            {
                                double valorTotal = 0;
                                i = 0;
                                while (i < n)
                                {
                                    valorTotal += cantidades[i] * precios[i];
                                    i++;
                                }
                                Console.WriteLine($"\nValor total del inventario: {valorTotal:C2}");
                            }
                            else
                            {
                                if (opción == 5)
                                {
                                    Console.WriteLine("Saliendo...");
                                }
                                else
                                {
                                    Console.WriteLine("Opción inválida.");   
                                }
                            }           
                        }
                    }
                }
            }
        }
    }
}