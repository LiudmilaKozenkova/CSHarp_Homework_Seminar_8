// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// {a, b}  {e, f} = {a*e+b*m, a*f+b*n}
// {c, d}  {m, n} = {c*e+d*m, c*f+d*n}

// Задаем две матрицы:
int[,] array = new int[2, 2]
{
    {2, 4},
    {3, 2},
};
int[,] matrix = new int[2, 2]
{
    {3, 4},
    {3, 3},
};

// int[,]result = new int [row, column];
// result[0, 0] = array[0,0]*matrix[0,0]+array[0,1]*matrix[1,0];
// result[0, 1] = array[0,0]*matrix[0,0]+array[0,1]*matrix[1,0];
// result[1, 0] = array[1,0]*matrix[0,0]+array[1,1]*matrix[1,0];
// result[1, 1] = array[0,0]*matrix[0,0]+array[0,1]*matrix[1,0];

// Метод перемножения 2х матриц
void Multiplication(int[,] array, int[,] matrix)
{
    int row = array.GetLength(1);
    int column = matrix.GetLength(0);
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < row; k++)
            {
                result[i, j] = result[i, j] + array[i, k] * matrix[k, j];

            }
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Multiplication(array, matrix);