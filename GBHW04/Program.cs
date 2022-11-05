// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
 Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

 int n0 = n / 10000;
 int n1 = n / 1000 % 10;
 int n2 = n / 100 % 10;
 int n3 = n / 10 % 10;
 int n4 = n % 10;

if (n0 == n4 && n1 == n3) 
{
    Console.WriteLine($"Number '{n}' является палиндромом");
 }
 else 
 {
    Console.WriteLine($"Number '{n}' не является палиндромом");
 }
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.WriteLine("Введите координаты точки А ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistanceIn3D(int x1_m, int y1_m, int z1_m, int x2_m, int y2_m, int z2_m)
{
    return Math.Sqrt((x2_m - x1_m) * (x2_m - x1_m) +
    (y2_m - y1_m) * (y2_m - y1_m) + (z2_m - z1_m) * (z2_m - z1_m));
}

double result = DistanceIn3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(result, 2)}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} -> {i*i*i}");
}