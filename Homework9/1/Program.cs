//Урок 9. Рекурсия
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



using static Common.Helper;

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());


GetNumberInBetween(n);

void GetNumberInBetween(int n)
{
    if (n < 0)
    {
        Console.Write($"{n} - не натуральное число!");
    }
    if (n == 0)
    {
        return;
    }
    Console.Write($"{n} ");
    GetNumberInBetween(n - 1);
}