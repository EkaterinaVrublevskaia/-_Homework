//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static Common.Helper;

int m = 3;
int n = 2;
int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

int[] avg = ArithmeticMean(n, array);
Console.Write("Среднее арифметическое элементов столбцов: ");
printArray(avg);

int[] ArithmeticMean(int n, int[,] array)
{
    
    int[] avg = new int[n];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];        
        }
        avg[i] = sum / array.GetLength(0);
    
    }
    return avg;
}

// Без метода
/*
for (int i = 0; i < array.GetLength(1); i++)
{
    int sum = 0;
    int avg = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j, i];
    }
    avg = sum / array.GetLength(0);
    Console.Write("Среднее арифметическое элементов столбца {0} = {1}", i, avg);
    Console.WriteLine();
}

*/


/*
int[] avg = new int[n];
for (int i = 0; i < array.GetLength(1); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j, i];        
    }
    avg[i] = sum / array.GetLength(0);
    
}
*/