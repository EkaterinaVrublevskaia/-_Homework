//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

using static Common.Helper;

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2DArrayspiral(size);
Console.WriteLine("Массив заполнен спирально: ");
Print2DArray(array);

int[,] Create2DArrayspiral(int size)
{
    int[,] array = new int[size, size];

    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= size * size)
    {
        array[i, j] = number;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++number;
    }
    return array;
}
