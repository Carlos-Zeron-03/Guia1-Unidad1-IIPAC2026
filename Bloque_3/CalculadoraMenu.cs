namespace Guia1_Unidad1.Bloque_3
{
    public class CalculadoraMenu
    {
        public CalculadoraMenu()
        {
            double resultado = 0;
            bool hayResultado = false;
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("--------- Calculadora con menú ----------");
                if (hayResultado)
                {
                    Console.WriteLine($"Resultado actual: {resultado}");     
                }

                Console.WriteLine("\n1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Reiniciar resultado");
                Console.WriteLine("9. Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 7)
                {  
                    double num;
                    if (!hayResultado)
                    {
                        Console.Write("Ingrese el primer número: ");
                        resultado = double.Parse(Console.ReadLine());
                        hayResultado = true;
                    }
                    switch (opcion)
                    {
                        case 1:
                        {
                            Console.Write("Ingrese el número a sumar: ");
                            num = double.Parse(Console.ReadLine());
                            resultado += num;    
                        }
                        break;

                        case 2:
                        {
                            Console.Write("Ingrese el número a restar: ");
                            num = double.Parse(Console.ReadLine());
                            resultado -= num;        
                        }
                        break;

                        case 3:
                        {
                            Console.Write("Ingrese el número a multiplicar: ");
                            num = double.Parse(Console.ReadLine());
                            resultado *= num;  
                        }
                        break;

                        case 4:
                        {
                            Console.Write("Ingrese el número a dividir: ");
                            num = double.Parse(Console.ReadLine());
                            if (num != 0)
                            {
                                resultado /= num; 
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede dividir entre cero.");    
                            }
                        }
                        break;

                        case 5:
                        {
                            Console.Write("Ingrese el exponente: ");
                            num = double.Parse(Console.ReadLine());
                            resultado = Math.Pow(resultado, num);    
                        }
                        break;

                        case 6:
                        {
                            if (resultado >= 0)
                            {
                                resultado = Math.Sqrt(resultado);         
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede calcular la raíz de un número negativo.");                    
                            }     
                        }
                        break;

                        case 7:
                        {
                            Console.Write("Ingrese el porcentaje: ");
                            num = double.Parse(Console.ReadLine());
                            resultado = resultado * (num / 100);       
                        }
                        break;
                    }
                    Console.WriteLine($"\nResultado: {resultado}");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    if (opcion == 8)
                    {
                        resultado = 0;
                        hayResultado = false;
                        Console.WriteLine("Resultado reiniciado.");
                        Console.ReadKey();
                    }     
                }
            } while (opcion != 9);
            Console.WriteLine("Programa finalizado.");
        }
    }
}