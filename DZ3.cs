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