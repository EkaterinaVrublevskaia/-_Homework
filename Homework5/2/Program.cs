//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных индексах.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//рандом массив - проверяем индексы на то что нечетные - сумируем их - сумма


Random random = new Random();
Console.Write("Введите длинну массива: ");
bool inParseArrayLength = int.TryParse(Console.ReadLine(), out int arrayLength);
if (inParseArrayLength)
{
    Console.WriteLine(arrayLength);
    
}

int[] randomArray = RandomNumberArray(arrayLength);
printArray(randomArray);

int sum = SumOddNumbersArray(randomArray);
Console.WriteLine($"Сумма нечетных чисел в массиве = {sum} "); 

int SumOddNumbersArray(int[] randomArray)
{
    int[] arr = randomArray;
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if((i % 2) != 0)
        {
            sum = sum + arr[i];           
             
        }   
          
        Console.WriteLine(sum);  
    }
    
    return sum;

}


int[] RandomNumberArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for(int i = 0; i < arrayLength; i++)
    {
        array[i] = random.Next(0, 1000);       
   
    }
    return array;
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");     
    }
    Console.WriteLine();  
}

 



