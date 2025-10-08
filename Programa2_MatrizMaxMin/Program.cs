using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, columnas];

        Console.WriteLine("\n--- Ingrese los valores de la matriz ---");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\n--- MATRIZ INGRESADA ---");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{matriz[i, j],5}");
            }
            Console.WriteLine();
        }

        int max = matriz[0, 0], min = matriz[0, 0];
        int filaMax = 0, colMax = 0, filaMin = 0, colMin = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > max)
                {
                    max = matriz[i, j];
                    filaMax = i;
                    colMax = j;
                }
                if (matriz[i, j] < min)
                {
                    min = matriz[i, j];
                    filaMin = i;
                    colMin = j;
                }
            }
        }

        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine($"Valor máximo: {max} en posición [{filaMax},{colMax}]");
        Console.WriteLine($"Valor mínimo: {min} en posición [{filaMin},{colMin}]");
    }
}