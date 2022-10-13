// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихсяn двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задаем 3х-мерный массив.
int[,,] matrix = new int[2, 2, 2];

// Метод распечатывания зх-мерного массива с указанием индексов каж эл-та
void Print (int[,,]array)
{
    int length = array.GetLength(0);
    int width = array.GetLength(1);
    int height = array.GetLength(2);
    for (int x = 0; x < length; x++)
{
    for (int y = 0; y < width; y++)
    {
        for (int z = 0; z < height; z++)
        {
            matrix[x, y, z] = new Random().Next(10, 100);
            Console.Write($"{matrix[x, y, z]}({x},{y},{z})" + " ");
        }
    }
    Console.WriteLine();
}
}
Print(matrix);
