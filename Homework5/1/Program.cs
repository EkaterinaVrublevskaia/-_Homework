//Урок 5. Функции и одномерные массивы
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//рандом - проверка на положительное 3 три числа - проверить числа четное или нет, если четное 
//записатьв cout

Random random = new Random();
Console.Write("Введите длинну массива: ");
bool inParseArrayLength = int.TryParse(Console.ReadLine(), out int arrayLength);
if (inParseArrayLength)
{
    Console.WriteLine(arrayLength);
    
}

int[] randomArray = RandomNumberArray(arrayLength);
printArray(randomArray);

int count = EvenNumbersArray(randomArray);
Console.WriteLine($"Количество четных чисел в массиве = {count}"); 

int EvenNumbersArray(int[] randomArray)
{
    int[] arr = randomArray;
    int count = 0;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if((arr[i] % 2) == 0)
        {
            count++;    
        }     
        //Console.WriteLine(count);  
    }
    
    return count;

}


int[] RandomNumberArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for(int i = 0; i < arrayLength; i++)
    {
        array[i] = random.Next(100, 1000);       
   
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

 
/*int[] array = new int[arrayLength];
for(int i = 0; i < arrayLength; i++)
{
    array[i] = random.Next(100, 1000);         
   
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");     
}
Console.WriteLine(); 

//bool number = random.Next(0, 10);
int[] arr = randomArray;
int count = 0;
    //int j = array[i];

for(int i = 0; i < arrayLength; i++)
{
    //Console.Write("a[{0}]=", i);
    if((arr[i] % 2) == 0)
    {
        count++; 
    }
       
   
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");   */ 
