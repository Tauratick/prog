﻿//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//  какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("введите число");
int number =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число");
int number1 =Convert.ToInt32(Console.ReadLine());
int max=number;
if(number1>max)
{
    Console.WriteLine(max=number1);
}
else
{
    Console.WriteLine(max=number);
}


//  Задача 4: Напишите программу, которая принимает на вход три числа и 
//  выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число");
int number2=Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число");
int number3=Convert.ToInt32(Console.ReadLine());

int max=number;

if(number2>max)
{
    Console.WriteLine(max=number2);
}
if(number3>max)
{
    Console.WriteLine(max=number3);
}
    
//  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//  является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("введите число");
int number=Convert.ToInt32(Console.ReadLine());

if (number % 2==1)
{
Console.WriteLine("Число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}

//задача 8 с циклом не разобрался на сайте напишу 