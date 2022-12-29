//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// пользователь вводит люьуе индексы, првоерки на то что такие индексы есть и если нет то вывод
// поиграться с авто. trygetfail  - bool
// out - число try значение в ауте, фолс - ничего


using static Common.Helper;

int m = 9;
int n = 9;

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

Console.Write("Введите значение строки двумерного массива = ");
int indexline = InputNumber();
Console.Write("Введите значение столбца двумерного массива = ");
int indexcolumn = InputNumber();
int number = Verification(indexline, indexcolumn, array);

int Verification(int indexline, int indexcolumn, int[,] array)
{
    int line = indexline - 1;
    int column = indexcolumn - 1;
    try
    {
        Console.WriteLine("Значение элемента массива = {0}", array[line, column]);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Выход из диапазона значений индекса строки {0}, столбца {1} в двумерном массиве", line, column);        
    }
    return array[line, column];
}

int InputNumber()
{
    bool inParseIndex = int.TryParse(Console.ReadLine(), out int index);
    if (inParseIndex)
    {
        //Console.Write(index);
    }
    return index;
}
