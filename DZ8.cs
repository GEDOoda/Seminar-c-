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

