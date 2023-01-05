//адача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using static Common.Helper;

Console.Write("Введите размер квадратного массива: ");
int sizeSquareArray = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2DArray(sizeSquareArray, sizeSquareArray);
Print2DArray(array);
(int, int) minSum = GetLineTheLowestSum(array);
//Console.WriteLine(minSum.Item1);
//Console.WriteLine(minSum.Item2);
Console.WriteLine("Cтрока с наименьшей суммой элементов под номером: " + (minSum.Item1) + ", с суммой элементов = " + (minSum.Item2));


(int, int) GetLineTheLowestSum(int[,] array)
{
    int minSum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];        
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexLine++;
        }    
    }
    return (indexLine, minSum);
}
