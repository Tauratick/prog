// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число ");
string num = Console.ReadLine();
int ff = num.Length;
if(ff==5)

if (num[0] == num[4] && num[1] == num[3])
{
 Console.WriteLine("Палиндром "+num);
}
else
{
    Console.WriteLine("не палиндром ");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("ведите число");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("ведите число");
int Y = int.Parse(Console.ReadLine());

Console.WriteLine("ведите число");
int Z = int.Parse(Console.ReadLine());

Console.WriteLine("ведите число");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("ведите число");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("ведите число");
int Z1 = int.Parse(Console.ReadLine());

double lenght=Math.Sqrt(Math.Pow(X1-X,2)+Math.Pow(Y1-Y,2)+Math.Pow(Z1-Z,2));
Console.WriteLine("Длина от точки до точки "+lenght);


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число");
int num=int.Parse(Console.ReadLine());

for(int I=1; I<=num; I++)
{
Console.WriteLine(Math.Pow(I,3));
}
Console.WriteLine("ступеней в таблице - " +num);
