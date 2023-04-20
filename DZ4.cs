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
