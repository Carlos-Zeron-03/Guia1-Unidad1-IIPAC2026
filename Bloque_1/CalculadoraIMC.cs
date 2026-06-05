namespace Guia1_Unidad1.Bloque_1
{
    public class CalculadoraIMC
    {
        public CalculadoraIMC()
        {
            Console.WriteLine("------ Calcular su IMC ------");
                        {
                            double peso, altura, imc;
                            Console.Write("Ingrese su peso en kg: ");
                            peso = Convert.ToDouble(Console.ReadLine());

                            if (peso <= 0)
                            // Si no es valido entra en el if, si es valido va de un solo al else.
                                {
                                    Console.WriteLine ("SU peso no es valido, debe ser un numero mayor a 0.");
                                }
                            else
                                {
                                    Console.Write("Ingrese su altura en metros: ");
                                    altura = Convert.ToDouble(Console.ReadLine());
                                    if (altura <= 0)
                                        {
                                            Console.WriteLine ("Su altura no puede ser menor o igual a 0, ingrese un valor valido.");
                                        }
                                    else
                                        {
                                            imc = peso / (altura * altura);
                                            Console.WriteLine("\n Su IMC es: " + imc);
                                            if (imc < 18)
                                                {
                                                    Console.WriteLine("Categoría: Bajo peso");
                                                }
                                            else 
                                                if (imc < 25)
                                                    {
                                                        Console.WriteLine("Categoría: Normal");
                                                    }
                                                else
                                                    if (imc < 30)
                                                        {
                                                            Console.WriteLine("Categoría: Sobrepeso");
                                                        }
                                                    else
                                                        {
                                                            Console.WriteLine("Categoría: Obesidad");
                                                        }
                                        }  
                    
                                }
                        }
        }
    }
}