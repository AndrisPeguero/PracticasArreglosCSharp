using System;

class Program
{
    static void Main()
    {
        // Matriz de calificaciones: 4 estudiantes x 3 asignaturas
        double[,] calificaciones = {
            { 85, 90, 78 },
            { 88, 92, 80 },
            { 75, 70, 68 },
            { 90, 95, 88 }
        };

        int numEstudiantes = calificaciones.GetLength(0);
        int numAsignaturas = calificaciones.GetLength(1);

        Console.WriteLine("Promedio por estudiante:");
        for (int i = 0; i < numEstudiantes; i++)
        {
            double suma = 0;
            for (int j = 0; j < numAsignaturas; j++)
            {
                suma += calificaciones[i, j];
            }
            double promedio = suma / numAsignaturas;
            Console.WriteLine($"Estudiante {i + 1}: {promedio:F2}");
        }

        Console.WriteLine("\nPromedio por asignatura:");
        for (int j = 0; j < numAsignaturas; j++)
        {
            double suma = 0;
            for (int i = 0; i < numEstudiantes; i++)
            {
                suma += calificaciones[i, j];
            }
            double promedio = suma / numEstudiantes;
            Console.WriteLine($"Asignatura {j + 1}: {promedio:F2}");
        }
    }
}