namespace Guia1_Unidad1.Bloque_5
{
    public class TicTacToe
    {
        public TicTacToe()
        {
            bool jugarDeNuevo = true;
            while (jugarDeNuevo)
            {
                char[,] tablero = new char[3, 3];
                InicializarTablero(tablero);
                char jugadorActual = 'X';
                bool juegoTerminado = false;
                while (!juegoTerminado)
                {
                    MostrarTablero(tablero);
                    Console.WriteLine($"\nTurno del jugador {jugadorActual}");
                    int fila, columna;

                    // Validar movimiento
                    while (true)
                    {
                        Console.Write("Ingrese fila (1-3): ");
                        fila = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Ingrese columna (1-3): ");
                        columna = int.Parse(Console.ReadLine()) - 1;
                        if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3)
                        {
                            if (tablero[fila, columna] == ' ')
                            {
                                tablero[fila, columna] = jugadorActual;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Esa posición ya está ocupada. Intente otra.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Posición inválida. Filas y columnas van de 1 a 3.");
                        }
                    }

                    // Verificar ganador
                    if (HayGanador(tablero, jugadorActual))
                    {
                        MostrarTablero(tablero);
                        Console.WriteLine($"\n¡Felicidades! Jugador {jugadorActual} ganó.");
                        juegoTerminado = true;
                    }
                    
                    // Verificar empate
                    else
                    {
                        if (Empate(tablero))
                        {
                            MostrarTablero(tablero);
                            Console.WriteLine("\n¡Empate!");
                            juegoTerminado = true;
                        }
                        else
                        {
                            // Cambiar jugador
                            jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
                        }
                    }
                }

                // Preguntar si quieren jugar de nuevo
                Console.Write("\n¿Desea jugar de nuevo? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                jugarDeNuevo = (respuesta == "s");
            }

            static void InicializarTablero(char[,] tablero)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    tablero[i, j] = ' ';
                }
            }

            static void MostrarTablero(char[,] tablero)
            {
                Console.Clear();
                Console.WriteLine("  1   2   3");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + 1);
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" " + tablero[i, j]);
                        if (j < 2)
                        {
                            Console.Write(" |");
                        }
                            
                    }
                    Console.WriteLine();
                    if (i < 2)
                    {
                        Console.WriteLine(" ---+---+---");
                    }
                }
            }

            static bool HayGanador(char[,] tablero, char jugador)
            {
                // Filas y columnas
                for (int i = 0; i < 3; i++)
                {
                    if ((tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador) || (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador))
                    {    
                        return true;
                    }
                }
                                
                // Diagonales
                if ((tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador) || (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador))
                {
                    return true;
                }
                return false;
            }

            static bool Empate(char[,] tablero)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    if (tablero[i, j] == ' ')
                    return false;
                    
                }
                return true;
            }
        }
    }
}