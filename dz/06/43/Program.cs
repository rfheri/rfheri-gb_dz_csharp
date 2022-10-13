// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("введите b1, k1, b2 и k2:");
double b1 = int.Parse(Console.ReadLine());
double k1 = int.Parse(Console.ReadLine());
double b2 = int.Parse(Console.ReadLine());
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1*(b2 - b1) / (k1 - k2) + b1;

if (k1 != k2) 
{Console.WriteLine($"{x}, {y}");}
else {
    Console.WriteLine("прямые не пересекаются");
}
