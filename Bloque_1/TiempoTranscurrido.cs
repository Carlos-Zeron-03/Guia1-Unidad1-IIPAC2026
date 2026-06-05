namespace Guia1_Unidad1.Bloque_1
{
    public class TiempoTranscurrido
    {
        public TiempoTranscurrido()
        {
            Console.Write("Ingrese la primer hora (HH:mm:ss): ");
            TimeSpan hora1;
            while (!TimeSpan.TryParse(Console.ReadLine(), out hora1))
            {
                Console.Write("Formato inválido. Ingrese la primer hora (HH:mm:ss): ");
            }
            Console.Write("Ingrese la segunda hora (HH:mm:ss): ");
            TimeSpan hora2;
            while (!TimeSpan.TryParse(Console.ReadLine(), out hora2))
            {
                Console.Write("Formato inválido. Ingrese la segunda hora (HH:mm:ss): ");
            }

            // Calcular diferencia total
            TimeSpan diferencia;               
            if (hora2 >= hora1)
            {
                diferencia = hora2 - hora1;  
            }
            else
            {
                diferencia = hora1 - hora2;
            }
            Console.WriteLine("\n-------- Resultado ------\n");
            Console.WriteLine("Diferencia: "+ diferencia.Hours + " horas " + diferencia.Minutes + " minutos " + diferencia.Seconds + " segundos");
        }
    }
}