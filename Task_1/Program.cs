// Задача 56.
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задаем двумерный массив.
int[,] matrix = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

// Метод получения суммы элементов в одной строке
int SumRow(int[,] array, int row)
{
    int sum = 0;
    for (int j = 0; j < 4; j++)
    {
        sum = sum + matrix[row, j];
    }
    return sum;
}

// Метод нахождения индекса строки с минимальной суммой элементов
int MinSumRow(int[,] array)
{
    int row = array.GetLength(0);
    int min = SumRow(array, 0);
    int minPos = 0;
    for (int i = 0; i < row; i++)
    {
        if (SumRow(matrix, i) < min) minPos = i;
    }
    return minPos;
}

// Значит, номер строки с наименьшей суммой элементов:
int numberRow = MinSumRow(matrix)+1;

Console.Write("Строка с наименьшей суммой элементов: ");
Console.WriteLine($"{numberRow} строка");


