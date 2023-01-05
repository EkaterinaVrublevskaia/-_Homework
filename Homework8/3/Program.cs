//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using static Common.Helper;


int size = 2;
int[,] arrayOne = CreateRandom2DArray(size, size);
int[,] arrayTwo = CreateRandom2DArray(size, size);
print2DArray(arrayOne);
print2DArray(arrayTwo);
Console.WriteLine("Произведение матриц: ");
int[,] matrixArray = GetMultiplicationMatrices(arrayOne, arrayTwo, size);
print2DArray(matrixArray);

int[,] GetMultiplicationMatrices(int[,] arrayOne,int[,] arrayTwo, int size)
{
    int[,] matrixArray = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixArray[i, j] = matrixArray[i, j] + (arrayOne[i, k] * arrayTwo[k, j]);
            }
        }   
    }
    return matrixArray;
}

void print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}