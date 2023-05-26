// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4
Console.Clear();
int count = 0, index =1;
while (count<1)
{
System.Console.WriteLine("Введите положительное число");
count = int.Parse(Console.ReadLine());
}
Console.Write($"{count} ->");
while (index<=count)
{
    Console.Write($" {Math.Pow(index,2)} ");
    index++;
} 
System.Console.WriteLine();

