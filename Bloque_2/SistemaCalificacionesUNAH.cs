namespace Guia1_Unidad1.Bloque_2
{
    public class SistemaCalificacionesUNAH
    {
        public SistemaCalificacionesUNAH()
        {
            int nota;

            // Validar que la nota esté entre 0 y 100
            do
            {
                Console.Write("Ingrese la nota (0-100): ");
                if (!int.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine("Error: debe ingresar un número entero.");
                    continue;
                }
                if (nota < 0 || nota > 100)
                {
                    Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
                }
            } while (nota < 0 || nota > 100);

            // Variables para la letra y descripción
            string nivel = "";
            string descripción = "";
            string resultado = "";

            // Determinar letra, descripción y aprobado/reprobado
            if (nota >= 95)
            {
                nivel = "Summa Cum Laude";
                descripción = "Excelente";
                resultado = "Aprobado";
            }
            else
            {
                if (nota >= 90)
                {
                    nivel = "Magna Cum Laude";
                    descripción = "Muy Bueno";
                    resultado = "Aprobado";
                }
                else
                {
                    if (nota >= 80)
                    {
                        nivel = "Cum Laude";
                        descripción = "Bueno";
                        resultado = "Aprobado";
                    }
                    else
                    {
                        if (nota >= 65)
                        {
                            nivel = "Ninguna";
                            descripción = "Regular";
                            resultado = "Aprobado";
                        }
                        else
                        {
                            nivel = "Ninguna";
                            descripción = "Insuficiente";
                            resultado = "Reprobado";
                        }
                    }
                }   
            }

            // Mostrar resultados
            Console.WriteLine("\nNota: " + nota);
            Console.WriteLine("Distinción honorifica: " + nivel);
            Console.WriteLine("Descripción: " + descripción);
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}