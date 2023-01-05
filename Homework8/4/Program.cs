//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

using static Common.Helper;

//Console.Write("Введите размерность 1: ");
int sizeOne = InputNumbers("Введите размерность 1: ");
int sizeTwo = InputNumbers("Введите размерность 2: ");
int sizeThree = InputNumbers("Введите размерность 3: ");

int[,,] array = CreateRandom3DArrayUnrepeatedNumbers(sizeOne, sizeTwo, sizeThree);
Console.WriteLine("Массив: ");
Print3DArray(array);
Console.WriteLine("Массив с выводом индексов каждого числа в основном массиве: ");
Write3DArray(array);

void Write3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} - [{i},{j},{k}]");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] CreateRandom3DArrayUnrepeatedNumbers(int sizeOne, int sizeTwo, int sizeThree)
{
    Random random = new Random();
    int[,,] array = new int[sizeOne, sizeTwo, sizeThree];
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number = 0;
    for (int l = 0; l < temp.GetLength(0); l++)
    {
        temp[l] = random.Next(10, 100);
        number = temp[l];
        if (l >= 1)
        {
            for (int m = 0; m < l; m++)
            {
                while (temp[l] == temp[m])
                {
                    temp[l] = random.Next(10, 100);
                    m = 0;
                    number = temp[l];
                }
                number = temp[l];
            }
        }
    }

    int count = 0;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[count];
                count++;
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

//Метод для создания 3D массива:
/*
int[,,] CreateRandom3DArray(int sizeOne, int sizeTwo, int sizeThree)
{
    Random random = new Random();
    int[,,] array = new int[sizeOne, sizeTwo, sizeThree];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(10, 100);
            }
        }
    }
    return array;
}
*/
