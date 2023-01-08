//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using static Common.Helper;

int m = InputNumbers("Введите число m: ");
int n = InputNumbers("Введите число n: ");

GetNumberSum(m, n, 0);

void GetNumberSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write($"Сумма натуральных элементов в промежутки от M до N = {sum} ");
        return;
    }
    sum = sum + m;
    m++;
    GetNumberSum(m, n, sum);
}
