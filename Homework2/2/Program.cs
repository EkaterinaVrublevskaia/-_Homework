//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
 
Console.WriteLine("Введите любое целое число ");
int num = int.Parse(Console.ReadLine());
if(num < 0)
{
    Console.WriteLine("Введенное число меньше или равно нулю!");
}
if(num > 99)
{
    while (num > 999)
    {
        num /= 10;
    }
    int thirdNum = (num % 10);
    Console.WriteLine($"Третьей цифрой числа является {thirdNum}");
}
if(num >= 0 && num <= 99)
{
    Console.WriteLine("У введенного числа нет 3 цифры");
}

