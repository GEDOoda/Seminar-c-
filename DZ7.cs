/*int [,] Random2dArray(int rows, int columns, int minValue, int maxValue)
{
    int [,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        array [i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;

}

void Show2dArray (int [,] array)

{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array [i,j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Random2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);*/

//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*double[,] Random2dArray(int rows, int cols, int minValue, int maxValue)
{
    double [,] array = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Math.Round(rand.Next(minValue, maxValue)*0.1, 1);
        }
    }
    return array;
}

void Show2dArray (double [,] array)

{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array [i,j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}
Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double [,] myArray = Random2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int [,] Random2dArray(int rows, int cols, int minValue, int maxValue)
{
    int [,] array = new int [rows, cols];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
        array [i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;

}

void Show2dArray (int [,] array)

{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array [i,j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Random2dArray(rows, cols, minValue, maxValue);
Show2dArray(myArray);

void ShowElement (int [,] array, int i, int j)
{
         if(i< array.GetLength(0) && j < array.GetLength(1))
        {
            Console.Write(array [i,j]);
        }
        else Console.WriteLine($"Позиции = Строка {i} и столбец {j} в массиве нет");
}
        

Console.Write("Input position of rows: ");
int operatorRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position of cols: ");
int operatorCols = Convert.ToInt32(Console.ReadLine());
ShowElement(myArray, operatorRows,operatorCols);*/


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// int [,] Random2dArray(int rows, int cols, int minValue, int maxValue)
// {
//     int [,] array = new int [rows, cols];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//         array [i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;

// }

// void Show2dArray (int [,] array)

// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//     Console.Write(array [i,j] + " ");
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// void ArithmeticMean (int [,] array)
// {
//   double [] sum = new double [array.GetLength(0)];
//   for(int j = 0; j < array.GetLength(1); j++)
//   {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//       sum [j] = sum [j] + array[i,j];
//     }
//     sum[j] = sum[j] / array.GetLength(1);
    
//   }
//   for (int i = 0; i < array.GetLength(0); i++)
//   Console.Write($"Среднее арифметическое стобца {i + 1} = {sum[i]}" + " ");
// }

// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = Random2dArray(rows, cols, minValue, maxValue);
// Show2dArray(myArray);

// ArithmeticMean(myArray);
