//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t");
        }
        Console.WriteLine();
    }
}

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void Average(int[,] array)
{
    Console.Write("Среднее арифметическое элементов столбцов - ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)} | ");
    }
}

Console.WriteLine("Колличество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колличество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[rows, colums];
Fill2DArray(table);
PrintArray(table);
Average(table);