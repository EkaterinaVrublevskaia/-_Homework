//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int N = int.Parse(Console.ReadLine());
int i = 1;
int res = i;
//if((N / 2) * 2 == N)
//{
//    Console.Write("Четное"); 
//}
//else
//{
//    Console.Write("Нечетное"); 
//}
if(N <= 1)
{
    Console.Write("Недопустимое значение числа N"); 
}
while (i <= N)
{
    if((res / 2) * 2 == res)
    {
        Console.WriteLine(i);
        res += 1;
    }
    else
    {
        res += 1;
    }
    i += 1;

}