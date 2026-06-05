namespace Guia1_Unidad1.Bloque_1
{
    public class ConversionTemperatura
    {
        public ConversionTemperatura()
        {
            int convertir;
            double temperatura, resultado;
                while(true)
                {
                    Console.WriteLine("\n------ Conversion de temperatura -----\n");
                    Console.WriteLine("1. Celsius a Fahrenheit\n");
                    Console.WriteLine("2. Celsius a Kelvin\n");
                    Console.WriteLine("3. Fahrenheit a Celsius\n");
                    Console.WriteLine("4. Fahrenheit a Kelvin\n");
                    Console.WriteLine("5. Kelvin a Celsius\n");
                    Console.WriteLine("6. Kelvin a Fahrenheit\n");
                    Console.WriteLine("7. Salir\n");
                    Console.Write("Seleccione una opción: ");
                    while (!int.TryParse(Console.ReadLine(), out convertir) || convertir < 1 || convertir > 7)
                        {
                            Console.Write("Opción inválida. Intente nuevamente: ");
                        }
                    if (convertir == 7)
                        {
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }
                    Console.Write("Ingrese la temperatura: ");
                    while (!double.TryParse(Console.ReadLine(), out temperatura))
                        {
                            Console.Write("Valor inválido. Ingrese nuevamente: ");
                        }
                    switch (convertir)
                        {
                            case 1:
                                resultado = (temperatura * 9 / 5) + 32;
                                Console.WriteLine("Resultado: " + resultado, "°F");
                            break;

                            case 2:
                                resultado = temperatura + 273.15;
                                Console.WriteLine("Resultado: " + resultado, "°K");
                            break;

                            case 3:
                                resultado = (temperatura - 32) * 5 / 9;
                                Console.WriteLine("Resultado: " + resultado, "°C");
                            break;

                            case 4:
                                resultado = (temperatura - 32) * 5 / 9 + 273.15;
                                Console.WriteLine("Resultado: " + resultado, "°K");
                            break;

                            case 5:
                                resultado = temperatura - 273.15;
                                Console.WriteLine("Resultado: " + resultado, "°C");
                            break;

                            case 6:
                                resultado = (temperatura - 273.15) * 9 / 5 + 32;
                                Console.WriteLine("Resultado: " + resultado, "°F");
                            break;
                        }

                };
        }
    }
}