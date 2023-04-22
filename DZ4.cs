//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Step(int arg1, int arg2)
{
    int stop = arg2;
    int result = 0;
    for(int count = 0;count < stop;count++)
    {
      result = arg1*arg1;
    }
    return result;
}
Console.WriteLine("Напишите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Напишите в какую степень необходимо возвести перове число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {numA} в степени числа {numB} равняется {Step(numA,numB)}");
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int [] myArray = new int [8];
Random rand = new Random();
void array(int [] massiv)
{
 int count = massiv.Length;
 for(int i = 0; i < count; i++)
 {
    myArray[i] = rand.Next(0,100);
    Console.WriteLine($"Значение элемента массива {i} = {myArray[i]}");
 }
}
array(myArray);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
void summa(int arg)
{
  int sum = 0;
  while(arg > 0)
  {
   int arg2 = arg % 10;
   sum = sum + arg2;
   arg = arg / 10;
  }
  Console.WriteLine($"Сумма цифр в заданном числе равняется {sum}");
}
Console.WriteLine("Введите целое число: ");
int operatorNum = Convert.ToInt32(Console.ReadLine());
summa(operatorNum);
*/
