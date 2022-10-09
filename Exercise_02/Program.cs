/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2 */

int rows = new Random().Next(3, 10);
int columns = new Random().Next(4, 10);

int[,] array = GetArray(rows, columns, -10, 30);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите строчку i: ");
int i = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите столбец j: ");
int j = int.Parse(Console.ReadLine()!);
Console.WriteLine();

if((i <= rows) && (j <= columns))
{
    Console.WriteLine($"В заданном массиве на позиции (i, j) находится значение {array[i, j]}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); 
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
