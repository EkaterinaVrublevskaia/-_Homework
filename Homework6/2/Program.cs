//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//пользователь задает значения - в методае выдаем результат
// x = b2 - b1 / (k2 - k1)
//y =k1*x +b1
//проверку надо доделать: деление на ноль + если паралельные прямые

//using Coomon.Helper;

Console.WriteLine("Нахождение точки пересечения двух прямых");
Console.WriteLine("Введите k1: ");
int k1 = InputNumber();
Console.WriteLine("Введите b1: ");
int b1 = InputNumber();
Console.WriteLine("Введите k2: ");
int k2 = InputNumber();
Console.WriteLine("Введите b2: ");
int b2 = InputNumber();
int[] arrayXY = LocateIntersectionPointTwoLines(k1, b1, k2, b2);
printArray(arrayXY);

int[] LocateIntersectionPointTwoLines(int k1, int b1, int k2, int b2)
{
    int x = 0;
    int y = 0;
    int i = 2;
    int b = b2 - b1;
    int[] array = new int[i];
    try 
    {
        x = (b2 - b1) / (k2 - k1);
        y = (k1 * x) + b1;
        array[0] = x;
        array[1] = y;
    }
    catch (DivideByZeroException) 
    {
        Console.WriteLine("Division of {0} by zero.", b);
    }
    return array;
}

int InputNumber()
{
    bool inParsenum = int.TryParse(Console.ReadLine(), out int num);
    if (inParsenum)
    {
        return num;
    }
    else
    {
        Console.Write("Введино некорректное число ");
        return -1;
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}


/*
//int check = Verification(k1, k2);
//Console.WriteLine(check);
int Verification(int k1, int k2)
{
    int k = k2 - k1;
    if(k != 0)
    {
        Console.WriteLine("Будем делить не на ноль!");
        return 1;
    }
    else
    {
        Console.WriteLine("Будем делить на ноль!");
        return -1;
    }
}*/
