//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите день недели числом ");
int num = int.Parse(Console.ReadLine());
if(num >= 1 | num <= 5)
{
    //Console.WriteLine("Данные дни являются рабочими");
    Console.WriteLine("Нет");
}

if(num == 6 | num == 7)
{
    //Console.WriteLine("Данные дни являются входными");
    Console.WriteLine("Да");
}

if(num <= 0 | num >= 8)
{
    Console.WriteLine("Вы ввели не корректное число ");
}
