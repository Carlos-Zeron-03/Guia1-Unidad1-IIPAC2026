namespace Guia1_Unidad1.Bloque_3
{
    public class JuegoAdivinanza
    {
        public JuegoAdivinanza()
        {
            Random random = new Random();
            // Iniciar un número random
            int numeroSecreto = random.Next(1, 101); // 1 a 100
            int intentosMáximos = 8;
            int intentosUsados = 1;
            bool adivino = false;
            Console.WriteLine("------ Juego de adivinar ------");
            Console.WriteLine("Tienes 7 intentos para adivinar el número (1-100)\n");
            while (intentosUsados < intentosMáximos && !adivino)
            {
                Console.Write("Intento " + intentosUsados + " : ");
                if (int.TryParse(Console.ReadLine(), out int numeroUsuario))
                {
                    intentosUsados++;
                    if (numeroUsuario == numeroSecreto)
                    {
                        adivino = true;
                    }
                    else 
                    {
                        if (numeroUsuario < numeroSecreto)
                        {
                            Console.WriteLine("El número es Mayor.\n");
                        }
                        else
                        {
                            Console.WriteLine("El número es Menor.\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. No se cuenta el intento.\n");
                }
            }
            Console.WriteLine("\n------ Resultado del juego -----\n");
            if (adivino)
            {
                Console.WriteLine("¡Felicidades que bien! Adivinaste el número en " + intentosUsados + " intentos.");
            }
            else
            {
                Console.WriteLine("No lograste adivinar el número perdedor.");
                Console.WriteLine("El número secreto era: " + numeroSecreto);
            }
            Console.WriteLine("Intentos usados: " + intentosUsados);
            Console.WriteLine($"Intentos restantes: {intentosMáximos - intentosUsados}");
        }
    }
}