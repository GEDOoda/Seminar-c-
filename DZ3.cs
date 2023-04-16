//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Coub (int arg)
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
Coub(operatorNumber);