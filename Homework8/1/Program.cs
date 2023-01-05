//Урок 8. Двумерные массивы. Продолжение
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
//двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

using static Common.Helper;

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2DArray(lines, columns);
Console.WriteLine("Рандомный массив: ");
Print2DArray(array);
int[,] arraySorting = DescendingSorting(array);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями: ");
Print2DArray(arraySorting);

int[,] DescendingSorting(int[,] array)
{
    int[,] arr = array;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = 0;
                    temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
    return arr;
}
/*
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
                int temp = 0;
                temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
Print2DArray(array);
*/
