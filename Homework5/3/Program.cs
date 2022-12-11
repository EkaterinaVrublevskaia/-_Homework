//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива. Не использовать готовые методы Min и Max
//[3 7 22 2 78] -> 76
 

Random random = new Random();
Console.Write("Введите длинну массива: ");
bool inParseArrayLength = int.TryParse(Console.ReadLine(), out int arrayLength);
if (inParseArrayLength)
{
    Console.WriteLine(arrayLength);
    
}

int[] randomArray = RandomNumberArray(arrayLength);
printArray(randomArray);

int min = MinNumberArray(randomArray);
Console.WriteLine($"Минимальное значение - {min}"); 
int max = MaxNumberArray(randomArray); 
Console.WriteLine($"Максимальное значение - {max}"); 
int result = max - min;
Console.WriteLine($"Разница между минимальным  и максимальным элементом в массиве = {result}"); 


int MinNumberArray(int[] randomArray)
{
    int[] arr = randomArray;
    int min = arr[0];
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];          

        }
        
    }
    return min;
}

int MaxNumberArray(int[] randomArray)
{
    int[] arr = randomArray;
    int max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];          
          
        }
        
    }
    return max; 
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


// в одном методе вычислить разницу между мак и мин

/*
int result = DivMaxMinMumbersArr(arrayLength);
Console.WriteLine($"Разница между минимальным  и максимальным элементом в массиве = {result}"); 
int DivMaxMinMumbersArr(int arrayLength)
{
    int result = 0;
    int[] arr = randomArray;
    int min = arr[0];
    int max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            int tempmin = arr[j];
            min = tempmin;
            
        }   
        if(arr[i] > max)
        {
            int tempmax = arr[k];
            max = tempmax;
       
        } 
        result = max - min;  
    }
    return result;
}
*/

// Без метода вычислить разницу между мах и мин


/*int result = 0;
    
for(int i = 0; i < randomArray.Length; i++)
{
    int min = randomArray[0];
    int max = randomArray[0];


    for(int j = 1; randomArray[j] < min; j++)
    {
        int tempmin = randomArray[j];
        min = tempmin;
        Console.WriteLine(min);
    }   
    for(int k = 1; randomArray[k] > max; k++)
    {
        int tempmax = randomArray[k];
        max = tempmax;
        Console.WriteLine(max);
    } 
    result = max - min;  
}

Console.WriteLine($"Разница между минимальным  и максимальным элементом в массиве = {result}");*/
