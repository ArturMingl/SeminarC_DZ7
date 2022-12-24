//Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.

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

void FindNumber(int[,] array, int number)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Это значение находится на позиции [{i},{j}]");
                k = 1;
            }
        }
    }
    if (k == 0)
        Console.WriteLine("Такого значения нет");
}

int[,] array = new int[5, 9];
Fill2DArray(array);
PrintArray(array);

Console.WriteLine("Введите значение");
int num = Convert.ToInt32(Console.ReadLine());

FindNumber(array, num);