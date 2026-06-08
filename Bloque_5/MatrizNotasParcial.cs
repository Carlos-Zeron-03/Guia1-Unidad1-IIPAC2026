namespace Guia1_Unidad1.Bloque_5
{
    public class MatrizNotasParcial
    {
        public MatrizNotasParcial()
        {
            int n;
            Console.Write("Ingrese el número de estudiantes: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Número inválido. Ingrese un valor mayor a 0: ");
            }
            int parciales = 3;
            double[,] notas = new double[n, parciales];
            int i = 0, j;

            // Llenar la matriz de notas
            while (i < n)
            {
                j = 0;
                while (j < parciales)
                {
                    Console.Write($"Ingrese la nota del estudiante {i + 1}, parcial {j + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out notas[i, j]) && notas[i, j] >= 0 && notas[i, j] <= 100)
                    {
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
                    }
                }
                i++;
            }

            // Promedio por estudiante
            double[] promedioEstudiante = new double[n];
            i = 0;
            while (i < n)
            {
                double suma = 0;
                j = 0;
                while (j < parciales)
                {
                    suma += notas[i, j];
                    j++;
                }
                promedioEstudiante[i] = suma / parciales;
                Console.WriteLine($"Promedio estudiante {i + 1}: {promedioEstudiante[i]:F2}");
                i++;
            }
                                
            // Promedio por parcial
            double[] promedioParcial = new double[parciales];
            j = 0;
            while (j < parciales)
            {
                double suma = 0;
                i = 0;
                while (i < n)
                {
                    suma += notas[i, j];
                    i++;
                }
                promedioParcial[j] = suma / n;
                Console.WriteLine($"Promedio parcial {j + 1}: {promedioParcial[j]:F2}");
                j++;
            }

            // Estudiante con mejor promedio
            double mejorProm = promedioEstudiante[0];
            int estudianteMejor = 1;
            i = 1;
            while (i < n)
            {
                if (promedioEstudiante[i] > mejorProm)
                {
                    mejorProm = promedioEstudiante[i];
                    estudianteMejor = i + 1;
                }
                i++;
            }
            Console.WriteLine($"\nEstudiante con mejor promedio: {estudianteMejor} ({mejorProm:F2})");

            // Parcial más difícil (menor promedio)
            double minParcial = promedioParcial[0];
            int parcialDifícil = 1;
            j = 1;
            while (j < parciales)
            {
                if (promedioParcial[j] < minParcial)
                {
                    minParcial = promedioParcial[j];
                    parcialDifícil = j + 1;
                }
                j++;
            }
            Console.WriteLine($"Parcial más difícil: {parcialDifícil} ({minParcial:F2})");
        }
    }
}