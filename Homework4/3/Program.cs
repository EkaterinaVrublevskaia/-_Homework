//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//метод желательно который заполняется пользователем из консоли


//  Не получается вывести массив в методе, без метода работает. Чуть ниже код   
//Console.Write("Введите длинну массива: ");
//int arrayLength = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите массив чисел: ");
//int[] arrayNum = ArrayNumbers(arrayLength);
//Console.Write($"{arrayNum}, ");
//printArray(arrayNum);
//int [] arrayNumbers = ArrayNumbers(numbers);
/*
int[] ArrayNumbers(int arrayLength)
{
    int[] array = new int[arrayLength];
    int i = 0;
    for(i = 0; i < arrayLength; i++)
    {
        //Console.Write("Введите массив чисел: ");
        bool inParseNumber = int.TryParse(Console.ReadLine(), out int number);
        if (inParseNumber)
        {
            array[i] = number; 
                                
        }
           
    }
    return array;  
}

void printArray(int[] array)
{
    
    for(int i = 0; i < array.Length; i++);
    {
      Console.Write($"{array}, ");           
    }
    Console.WriteLine(); 
}*/

//Без метода работает
Console.Write("Введите длинну массива: ");
bool inParseArrayLength = int.TryParse(Console.ReadLine(), out int arrayLength);
if (inParseArrayLength)
{
    Console.WriteLine(arrayLength);
    
}
int[] array = new int[arrayLength];
for(int i = 0; i < arrayLength; i++)
{
    bool inParseNumber = int.TryParse(Console.ReadLine(), out int number);
    if (inParseNumber)
    {
        Console.WriteLine(number);
        array[i] = number;
        
        
    }
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");     
}
Console.WriteLine(); 


