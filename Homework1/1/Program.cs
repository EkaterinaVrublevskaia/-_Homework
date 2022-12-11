//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.Write("Max = ");
    Console.WriteLine(a);
    Console.Write("Min = ");
    Console.WriteLine(b);
}
if(a < b)
{
    Console.Write("Max = ");
    Console.WriteLine(b);
    Console.Write("Min = ");
    Console.WriteLine(a);
}
if(a == b)
{
    Console.WriteLine("Числа равны");
}

