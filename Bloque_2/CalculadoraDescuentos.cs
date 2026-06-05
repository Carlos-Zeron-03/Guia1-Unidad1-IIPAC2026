namespace Guia1_Unidad1.Bloque_2
{
    public class CalculadoraDescuentos
    {
        public CalculadoraDescuentos()
        {
            double monto;

            // Pedir el monto de compra
            Console.Write("Ingrese el monto de la compra: L. ");
            while (!double.TryParse(Console.ReadLine(), out monto) || monto < 0)
            {
                if (monto < 0)
                {
                    Console.WriteLine("Valor no valido, tiene que ser un valor positivo.");
                    Console.Write("Ingrese el monto de la compra: L. ");
                }
            };
            double descuento = 0;

            // Determinar porcentaje de descuento
            if (monto >= 2500)
            {
                descuento = 0.15; // 15%
            }
            else
            {
                if (monto >= 1000)
                {
                    descuento = 0.10; // 10%
                }
                else
                {
                    if (monto >= 500)
                    descuento = 0.05; // 5%   
                }
            }

            // Calcular valores
            double montoDescuento = monto * descuento;
            double precioFinal = monto - montoDescuento;

            // Mostrar resultados
            Console.WriteLine($"\nPrecio original: L. {monto:F2}");
            Console.WriteLine($"Descuento aplicado: L. {montoDescuento:F2} ({descuento * 100}%)");
            Console.WriteLine($"Precio final: L. {precioFinal:F2}");  
        }
    }
}