//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] Random2dArray(int rows, int cols, int minValue, int maxValue)
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

// void Descend(int [,] array)
// {  
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//    for(int j = 0; j < array.GetLength(1) - 1; j++)
//    {
//     for(int k = 0; k < array.GetLength(1) - j -1; k++)
//     {
//       if(array[i,k] < array[i,k + 1])
//       {
//         int temp = array[i,k];
//         array[i,k] = array[i,k + 1];
//         array[i,k + 1] = temp;
//       }
//     }
//    }      
//   }
//   for(int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }


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
// Descend(myArray);


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void IndexMinSumRow( int [,] array)
// {
//   int MinSumRow = 0;
//   int MinSum = int.MaxValue; // Представляет наибольшее возможное значение типа Int32. Это поле является константой. В интернете нашел такую. 
  //По факту можно просто большое число чтобы оно явно было больше суммы первой строки.Чтобы сразу же туда попала сумма из первой строки для сравнения с другими.
//   for(int i = 0; i < array.GetLength(0); i++)
//   {
//     int sum = 0;
//     for(int j = 0;j < array.GetLength(1); j++)
//     {
//      sum += array[i,j];
//     }
//     if(sum < MinSum)
//     {
//       MinSum = sum;
//       MinSumRow = i;
//     }
//   }
//   Console.WriteLine($"Строка с наименьшей суммой является " + (MinSumRow + 1));
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
// IndexMinSumRow(myArray);