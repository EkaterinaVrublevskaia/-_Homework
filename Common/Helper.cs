namespace Common;

public static class Helper
{
    public static int InputNumbers(string input)
    {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

    public static void Print2DArray(int[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void Print2DdoubleArray(double[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static double[,] CreateRandom2DDoubleArray(int CountOfRows, int CountOfColumns)
    {
        Random random = new Random();
        double[,] array = new double[CountOfRows, CountOfColumns];
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round(random.NextDouble() * (-11 + 10) - 10, 2);
            }
        }
        return array;
    }

    public static int[,] CreateRandom2DArray(int CountOfRows, int CountOfColumns)
    {
        Random random = new Random();
        int[,] array = new int[CountOfRows, CountOfColumns];
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(0, 15);
            }
        }
        return array;
    }

    public static int[] RandomNumberArray(int arrayLength)
    {
        Random random = new Random();
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(100, 1000);
        }
        return array;
    }

    public static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine();
    }

    public static int[] ArrayNumbers(int arrayLength)
    {
        int[] array = new int[arrayLength];
        int i = 0;
        for (i = 0; i < array.Length; i++)
        {
            bool inParseNumber = int.TryParse(Console.ReadLine(), out int number);
            if (inParseNumber)
            {
                array[i] = number;
            }
        }
        return array;
    }

    public static int InputNumber()
    {
        bool inParsenum = int.TryParse(Console.ReadLine(), out int num);
        if (inParsenum)
        {
            return num;
        }
        else
        {
            Console.Write("Введино некорректное число ");
            return -1;
        }
    }
}
