//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void Coub (int arg)
{
    int number = 1;
    
    while(number < arg)//Если требуется включить число N в таблицу то здесь требуется поставить знак "<="
    {
        int result = number * number * number;
        Console.WriteLine(result);
        number = number + 1;
    }
}

Console.WriteLine("Input number: ");
int operatorNumber = Convert.ToInt32(Console.ReadLine());
Coub(operatorNumber);*/

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*string Polindrom(int arg)
{
    int end = arg % 10; int beforeLast = arg % 100 / 10;//последние два числа
    int first = arg / 10000; int second = arg / 1000 % 10;//первые два числа
    if(end == first && beforeLast == second)
    {
        return "Число является палиндромом!";
    }
    else
    {
        return "Число не является палиндромом!";
    }
}
Console.WriteLine("Введите целое пятизначное число: ");
int operatorNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Polindrom(operatorNumber));*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double rast (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double kvrast = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1);
    double result = Math.Sqrt(kvrast);
    return Math.Round (result,2);
}
Console.WriteLine("Напишите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между вдумя точками в 3D простастве ялвяется - {rast(x1,y1,z1,x2,y2,z2)}");*/


//Напишите программу, которая принимает на вход число N и проверяет, является ли оно палиндромом.

/*string Polindrom(int arg)
{
    int num = 0;
    int num2 = arg;
    while(num2 > 0)
    {
        num = num * 10 + num2 % 10;
        num2 = num2 / 10;
    }
    if(arg == num)
    {
        return "Число является палиндромом";
    }
    else
    {
        return "Число не является палиндромом";
    }
    
}
Console.WriteLine("Укажите целое число: ");
int operatorNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Polindrom(operatorNum));*/