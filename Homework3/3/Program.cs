//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
//Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int Number = GetVerification();

int[] CubeTable = GetArrayNumbers(Number);

PrintАrray(CubeTable);

int GetVerification()
{
    Console.WriteLine("Введите целое чилсо ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int N);
    if(isParsedN)
    {
        return N;
    }
    else
    {   
        Console.Write("Вы ввели некооректное значение ");
        return -1;
    }
}

int[] GetArrayNumbers(int Number)
{
    int[] array = new int[Number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = (int)(Math.Pow(i + 1, 3));
    }
    return array;
}

void PrintАrray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}
