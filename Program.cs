// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//НАЧАЛО

/*int CutNumber(int num)
{
    int tenNumber = num / 10;
    int result = tenNumber % 10;
    return result;
}
Console.WriteLine("Введите ваше целое трехзначное число: ");
int finalNumber = Convert.ToInt32(Console.ReadLine());

int finish = CutNumber(finalNumber);
Console.WriteLine($"Вторя цифра {finish}");*/
//Конец

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Начало
/*Console.WriteLine("Введите ваше целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if(Number / 100 > 0)
{
while(Number > 1000)
{
Number = Number / 10;
}
Number = Number % 10;
Console.WriteLine("Третья цифра:" + Number);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//НАЧАЛО
/*string Weekend(int num)
{
    if(num == 6 ^ num == 7)
    return "выходной";
    else
    {
    return "этот день не является выходным";      
    }
}
Console.WriteLine("Введите день недели от 1 до 7: ");
int operatorDay = Convert.ToInt32(Console.ReadLine());
string result = Weekend(operatorDay);
Console.WriteLine(result);*/