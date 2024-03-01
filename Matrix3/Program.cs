using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк (N): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (M): ");
        int m = int.Parse(Console.ReadLine());

        // Создаем матрицу
        int[,] matrix = new int[n, m];

        // Заполняем матрицу пользовательским вводом
        Console.WriteLine("Введите элементы матрицы:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Находим сумму элементов каждой строки и выводим результат
        Console.WriteLine("Сумма элементов каждой строки:");

        for (int i = 0; i < n; i++)
        {
            int sumRow = 0;
            for (int j = 0; j < m; j++)
            {
                sumRow += matrix[i, j];
            }
            Console.WriteLine($"Строка {i + 1}: {sumRow}");
        }

        // Находим сумму элементов каждого столбца и выводим результат
        Console.WriteLine("Сумма элементов каждого столбца:");

        for (int j = 0; j < m; j++)
        {
            int sumCol = 0;
            for (int i = 0; i < n; i++)
            {
                sumCol += matrix[i, j];
            }
            Console.WriteLine($"Столбец {j + 1}: {sumCol}");
        }
    }
}
