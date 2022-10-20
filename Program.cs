// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("введите число");
int number=Convert.ToInt32(Console.ReadLine());

int number1=(number%100)/10;
Console.WriteLine("вторая цифра " +number1);


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите число");
int number =Convert.ToInt32(Console.ReadLine());

if(number>= 1 && number <= 7)

if(number == 7) 
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("Рабочие дни");
}
