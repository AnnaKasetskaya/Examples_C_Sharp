﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 == number2)
// {
//     Console.WriteLine("Числа равны");
// }
// else if(number1 > number2)
// {
//     Console.WriteLine("Первое число больше второго");
// }
// else
// {
//     Console.WriteLine("Второе число больше первого");
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;

// if(number2 > number1)
// {
//     max = number2;
//     if(number3 > number2)
//     {
//         max = number3;
//     }
// }
// else if(number3 > number1)
// {
//     max = number3;
// }
// Console.WriteLine("Максимальное число: " + max);




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//    Console.WriteLine("Число четное");
// }
// else 
// {
//     Console.WriteLine("Число нечетное");
// }




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int count = 2;

// while(count <= N)
// {
//    Console.Write(count + ", ");
//    count += 2;
// }




// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int count = -N;

// while(count <= N)
// {
//    Console.Write(count + ", ");
//    count += 1;
// }




// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N >= 100 && N < 1000)
{
    int  LastDigit = N % 10;
    Console.WriteLine(LastDigit);
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}