//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//метод найти каждое число и сложить

Console.Write("Введите число: ");
int number = InputIntNumber();
int sum = CountNumbers(number);
Console.WriteLine($"Сумма цифр введенного числа = {sum}");

int InputIntNumber()
{
    bool inParse = int.TryParse(Console.ReadLine(), out int number);

    if (inParse)
    {
        return number;
    }
    else
    {
        Console.Write("Введино некорректное число ");
        return -1;
    }
}

int CountNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int tempNumber = number % 10;
        sum = sum + tempNumber;
        number = number / 10;
    }
     return sum;
}