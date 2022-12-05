//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число ");
bool isParse = int.TryParse(Console.ReadLine(), out int Number);
//if(Number > 9999 | Number < 100000)
//{
//    Console.WriteLine("Число целое и пятизначное ");
//}
//else
//{   
//    Console.WriteLine("Вы ввели некооректное значение ");
//}

int[] array = new int[0];

int[] ReversArray = GetReversarray(array);    

int[] IntegerArray = GetIntegerArray(Number);

PrintАrray(array);

if(array.Length == Number)
{
    Console.WriteLine("Palindrome");
}
else 
{
    Console.WriteLine("Not palindrome");
}

int [] GetReversarray(int[] array)
{
    int i = 0;
    int length = array.Length;
    int Revers = length - 1;
    int[] arrayRevers = new int[array.Length];
    while(i < length)
    {
        arrayRevers[i] =  array[Revers];
        i++;
        Revers = Revers -1;
        return arrayRevers; 
    }
}

void PrintАrray(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(Array[i]); 
    }
    
}

//Если отдельно делать, возникает ошибка:
//Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//at Program.<Main>$(String[] args) in C:\tich\Program_leng\Homework\Homework3\4\Program.cs:line 8
//int tempNum = number % 10;
//Console.WriteLine(temp);
//int i = 0;
//int[] array = new int[i];
//array[i] = tempNum;
//PrintАrray(array);

int[] GetIntegerArray (int number)
{
    int i = 0;
    while(number / 10 != 0)
    {
        int tempNum = number % 10;
        array[i] = tempNum;
        number = number / 10;
        i++;
    }
    return array;
}