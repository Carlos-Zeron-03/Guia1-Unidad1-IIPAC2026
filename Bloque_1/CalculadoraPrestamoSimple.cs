namespace Guia1_Unidad1.Bloque_1
{
    public class CalculadoraPrestamoSimple
    {
        public CalculadoraPrestamoSimple()
        {
            double monto, tasaAnual, tasaMensual, cuota;
            int meses;
            Console.Write("Ingrese el monto del préstamo: ");
            monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la tasa de interés anual (%): ");
            tasaAnual = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el plazo en meses: ");
            meses = Convert.ToInt32(Console.ReadLine());
            // Convertir tasa anual a mensual
            tasaMensual = (tasaAnual / 100) / 12;
            // Calcular cuota mensual fija
            cuota = monto * (tasaMensual * Math.Pow(1 + tasaMensual, meses)) 
            / (Math.Pow(1 + tasaMensual, meses) - 1);
            // Calcular total pagado e interés total
            double totalPagado = cuota * meses;
            double interésTotal = totalPagado - monto;

            Console.WriteLine("\n------ Resultado Final ------\n");
            Console.WriteLine($"Cuota mensual: {cuota:F2}");
            Console.WriteLine($"Interés total: {interésTotal:F2}");
            Console.WriteLine($"Total pagado: {totalPagado:F2}" + " Lempiras\n");
        }
    }
}