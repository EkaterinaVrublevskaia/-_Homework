Console.WriteLine("Введите пятизначное число ");
//bool isParseX = int.TryParse(Console.ReadLine(), out int number);
bool  isParse = int.TryParse(Console.ReadLine(), out int number);
int temp = number % 10;
Console.WriteLine(temp);
int i = 0;
int[] array = new int[i];
array[i] = temp;
Console.WriteLine(array);
PrintАrray(array);

void PrintАrray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}


int[] InputArray = new int[4];
InputArray[0] = 5;
InputArray[1] = 8;
InputArray[2] = 1;
InputArray[3] = 8;
InputArray[4] = 5;


PrintАrray(InputArray);
