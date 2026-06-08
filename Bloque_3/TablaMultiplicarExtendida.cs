namespace Guia1_Unidad1.Bloque_3
{
    public class TablaMultiplicarExtendida
    {
        public TablaMultiplicarExtendida()
        {
            Console.Write("Que tabla desea ver? : ");
            
            //leemos el numero base
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTabla del " + numero + ":");
            // Ciclo del 1 al 12, para las tablas de multiplicar
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                // Si el número 'i' es menor a 10, le agregamos un espacio para que 
                // los signos '=' queden uno debajo del otro.
                string espacio = (i < 10) ? " " : ""; 
                Console.WriteLine(numero + " x " + espacio + i + " = " + resultado);
            }
        }
    }
}