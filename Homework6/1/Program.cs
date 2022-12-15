//Урок 6. Одномерные массивы. Продолжение
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3 float

using static Coomon.Helper;

Console.Write("Введите количество вводимых чисел: ");
int arrayLength = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int[] arrayNum = ArrayNumbers(arrayLength);
//Console.Write($"{arrayNum}, ");
Common.Helper.printArray(arrayNum);
int count = QuantityNumberOverZero(arrayNum);
Console.Write($"Количество введенных пользователем чисел больше 0 = {count}");


int QuantityNumberOverZero(int[] array)
{
    int[] arr = array;
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            count++;
        }      
    }
    return count;
}

/*
int[] ArrayNumbers(int arrayLength)
{
    int[] array = new int[arrayLength];
    int i = 0;
    for(i = 0; i < array.Length; i++)
    {
        bool inParseNumber = int.TryParse(Console.ReadLine(), out int number);
        if (inParseNumber)
        {
            array[i] = number;                                 
        }         
    }
    return array;  
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");     
    }
    Console.WriteLine();  
}

*/


