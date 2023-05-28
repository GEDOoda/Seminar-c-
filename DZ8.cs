//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

// Console.Write("Input a quantity of rows: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of cols: ");
// int cols1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of minValue: ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of maxValue: ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());

// int [,] array1 = Random2dArray(rows1, cols1, minValue1, maxValue1);
// //Инициировали первую матрицу 

// Console.Write("Input a quantity of rows: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of cols: ");
// int cols2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of minValue: ");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of maxValue: ");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());

// int [,] array2 = Random2dArray(rows2, cols2, minValue2, maxValue2);
// //Инициировали вторую матрицу

// void MultiArray(int [,] array1,int [,] array2)
// {
//   if(cols1 != rows2)
//   {
//     Console.WriteLine("Умножение этих матриц невозможно так как количество стобцов перовй матрицы не равно количеству строк второй матрицы");
//   }
//   else
//   {
//    int [,] result = new int[rows1,cols2];
//    for(int i = 0; i < array1.GetLength(0); i++)
//    {
//     for(int j = 0; j < array2.GetLength(1); j++)
//     {
//       int sum = 0;
//       for(int k = 0; k < cols1; k++)
//       {
//         sum += array1[i,k] * array2[k,j];
//       }
//       result[i,j] = sum;
//     }
//    }
//    Console.WriteLine("Результат умножения матриц: ");
//    for(int i = 0; i < array1.GetLength(0); i++)
//    {
//     for(int j = 0; j < array2.GetLength(1); j++)
//     {
//       Console.Write(result[i,j] + " ");
//     }
//     Console.WriteLine();
//    }
//   }
// }

// Show2dArray(array1);
// Show2dArray(array2);
// MultiArray(array1,array2);
