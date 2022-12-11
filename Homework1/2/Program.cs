//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if(a > b & a > c) 
{
    Console.Write("Max = ");
    Console.WriteLine(a);
}
if(b > a & b > c)
{
    Console.Write("Max = ");
    Console.WriteLine(b);
} 
if(c > b & c > a)
{
    Console.Write("Max = ");
    Console.WriteLine(c);
} 
