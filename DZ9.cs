// //Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// Console.WriteLine("Введите ваше число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// void PrintNumber(int k)
// {
//     if(k > 0)
//     {
//         Console.WriteLine(k);
//         k--;
//         PrintNumber(k);//Понятия не имею почему выводит введенную цифру дважды
        
//     }
// }

// PrintNumber(num);

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("Программа покаже сумму натуральных чисел от первого введенного чила до второго. Введите ваше перове число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ваше второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int M, int N)
// {
//   int sum = 0;
//   if(M < N)
//   {
//   for(int i = M;i <= N; i++)
//   {
//     sum += i;
//   }
//   return sum;
//   }
//   else
//   {
//     for(int i = N;i <= M; i++)
//   {
//     sum += i;
//   }
//   return sum;
//   }
// }
// Console.WriteLine($"Сумма натуральных чисел от числа {num1} до числа {num2} равна {SumNumbers(num1,num2)}");