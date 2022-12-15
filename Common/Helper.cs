namespace Common;

public static class Helper
{
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
            Console.Write($"{array[i]} ");
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
