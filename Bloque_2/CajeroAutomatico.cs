namespace Guia1_Unidad1.Bloque_2
{
    public class CajeroAutomatico
    {
        public CajeroAutomatico()
        {
            int saldo = 50000; // Saldo inicial
            int retiro;
            Console.WriteLine("Saldo disponible: L. " + saldo);

            // Solicitar monto
            Console.Write("Ingrese el monto a retirar: L. ");
            if (!int.TryParse(Console.ReadLine(), out retiro) || retiro <= 0)
            {
                Console.WriteLine("Monto inválido.");
                return;
            }

            // Validaciones
            if (retiro % 20 != 0)
            {
                Console.WriteLine("El monto debe ser múltiplo de 20.");
                return;
            }
            if (retiro > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
                return;
            }

            // Cálculo de billetes (500, 100, 50, 20)
            int b500 = retiro / 500;
            retiro %= 500;
            int b100 = retiro / 100;
            retiro %= 100;
            int b50 = retiro / 50;
            retiro %= 50;
            int b20 = retiro / 20;

            // Actualizar saldo
            saldo -= (b500 * 500 + b100 * 100 + b50 * 50 + b20 * 20);

            // Mostrar resultados
            Console.WriteLine("\nDesglose de billetes:");
            if (b500 > 0) Console.WriteLine("Billetes de 500: " + b500);
            if (b100 > 0) Console.WriteLine("Billetes de 100: " + b100);
            if (b50 > 0) Console.WriteLine("Billetes de 50: " + b50);
            if (b20 > 0) Console.WriteLine("Billetes de 20: " + b20);
            Console.WriteLine("\nNuevo saldo: L. " + saldo);
        }
    }
}