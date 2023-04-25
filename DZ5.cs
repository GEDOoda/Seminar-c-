// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*int [] myArray = new int [10];
Random rand = new Random();
void array(int [] massiv)
{
 int count = massiv.Length;
 for(int i = 0; i < count; i++)
 {
    myArray[i] = rand.Next(99,1000);
    Console.WriteLine($"Значение элемента массива {i} = {myArray[i]}");
 }
}

int amount(int [] massiv)
{
    int count = 0;
    for(int i = 0;i < massiv.Length;i++)
    {
        if(massiv[i] % 2 == 0)
        {
         count = count + 1;
        }
    }
    return count;
}
array(myArray);
Console.WriteLine("Количество четных чисел равно " + amount(myArray));*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int [] myArray = new int [10];
Random rand = new Random();
void array(int [] massiv)
{
 int count = massiv.Length;
 for(int i = 0; i < count; i++)
 {
    myArray[i] = rand.Next(0,10);
    Console.WriteLine($"Значение элемента массива {i} = {myArray[i]}");
 }
}

int Summa(int [] massiv)
{
    int sum = 0;
    for(int i = 1;i <massiv.Length;i += 2)
    {
        sum += massiv[i];
    }
    return sum;
}
array(myArray);
Console.WriteLine("Сумма элементов стоящих на нечетных позициях равна " + Summa(myArray));*/