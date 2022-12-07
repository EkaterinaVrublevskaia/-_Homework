//Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и 
//метод который возводит число A в натуральную степень B. Задание должно быть 
//выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()
//3,5 -Ю 243(3в5)
//2,4-Ю 16(2в4)

// Работает, но между вводом А и В от пользователя пробел идет в терминале

Console.Write("Введите первое число A: ");
int A = InputNumber();
Console.Write("Введите второе число B: ");
int B = InputNumber();
int NumberByPower = MultiplyNumberByPower(A, B);
Console.Write($"Число {A} возведенное в степь числа {B} = {NumberByPower}");
int InputNumber()
{
    bool inParseA = int.TryParse(Console.ReadLine(), out int A);
    bool inParseB = int.TryParse(Console.ReadLine(), out int B);
    if (inParseA)
    {
        return A;
    }
    if (inParseB)
    {
        return B;
    }   
    else
    {
        Console.Write("Введино некорректное число ");
        return -1;
    }
}

int MultiplyNumberByPower(int a, int b)
{
    int temp = a;
    for(int i = 1; i < b; i++)
    {
    a *= temp;
    }
    return a;

}


