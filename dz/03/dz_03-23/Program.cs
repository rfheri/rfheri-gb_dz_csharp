//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine());
int count = 1;

Console.WriteLine($"кубы числа от 1 до {a}:  ");
while (count <= a)
{
    Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
    count++;
}