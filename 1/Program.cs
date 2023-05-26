// See https://aka.ms/new-console-template for more information
// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.WriteLine("Введите номер четверти(от 1 до 4)");
int num = int.Parse(Console.ReadLine());
while (num>4||num<1)
{
    Console.WriteLine("Введите номер четверти(от 1 до 4)");
    num = int.Parse(Console.ReadLine());
}
if (num==1)
{
    System.Console.WriteLine("X>0,Y>0");
} else if (num==2)
        {
            System.Console.WriteLine("X<0,Y>0");
        } else if (num==3)
        {
            System.Console.WriteLine("X<0,Y<0");
        } else 
        System.Console.WriteLine("X>0,Y<0");
