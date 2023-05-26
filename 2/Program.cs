// See https://aka.ms/new-console-template for more information
// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);
Console.Clear();
System.Console.WriteLine("Введите Ax");
int Ax = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Ay");
int Ay= int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Bx");
int Bx = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите By");
int By = int.Parse(Console.ReadLine());
double sqrt = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2));
Console.WriteLine($"sqrt={sqrt:f2}");
