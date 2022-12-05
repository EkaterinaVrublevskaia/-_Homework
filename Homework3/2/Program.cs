//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//d = sgrt(a^2 + b^2 + c^2). sgrt – это корень квадратный.
//D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)


double ax = GetVerification();
double bx = GetVerification();
double ay = GetVerification();
double by = GetVerification();
double az = GetVerification();
double bz = GetVerification();

double result = GetDistanceBetweenPoints(ax, bx, ay, by, az, bz);
Console.WriteLine(result);

double GetVerification()
{
    Console.WriteLine("Введите число ");
    bool isN = int.TryParse(Console.ReadLine(), out int N);
    if(isN)
    {
        return N;
    }
    else
    {
        Console.Write("Вы ввели некооректное значение ");
        return -1;
    }
}

double GetDistanceBetweenPoints(double ax, double bx, double ay, double by, double az, double bz)
{
    //double Number = Math.Sqrt((bx - ax)*(bx - ax) + (by - ay)*(by - ay) + (bz - az)*(bz - az));
    double Number = Math.Sqrt((Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)));
    return Number;
}