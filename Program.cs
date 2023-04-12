//ЗАДАЧА - 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//НАЧАЛО
/*
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Программа покажет какое число большее и какое число меньшее");
int max = num1;
int min = num2;
if(num2 < max)
{
    Console.WriteLine("Большее число: " + max + " Меньшее число: " + min);
}
else
{
    max = num2;
    min = num1;
    Console.WriteLine("Большее число: " + max + " Меньшее число: " + min);   //НЕ ОБРАЩАЮ ВНИАНИЕ НА ОШИБКИ ПРО ПОВТОРЕНИЕ АТРИБУТОВ ПРОГРАММА ЖЕ РАБОТАЕТ
}
*/
//КОНЕЦ

//ЗАДАЧА - 2. Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
//НАЧАЛО
/*
Console.WriteLine("Программа покажет какое из введеных вами чисел будет наибольшим.");
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}
Console.WriteLine("Наибольшее число: " + max);
*/
//КОНЕЦ

//ЗАДАЧА - 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//НАЧАЛО
/*Console.Write("Прогрмамма покажет четное ли число введеное вами. Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0){
    Console.WriteLine("Ваше число четное");
}
else{
    Console.WriteLine("Ваше число нечетное");
}*/
//КОНЕЦ

//ЗАДАЧА - 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//НАЧАЛО
Console.WriteLine("Программа покажет четные числа от 1 до введенного вами. Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= num)
{
    if(current % 2 == 0){
    Console.WriteLine(current + " ");
    ++current;//current = current +1
    }
    else
    {
        ++current;
    }
};

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
