// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("введите число А:");
int a = int.Parse(Console.ReadLine());
Console.Write("введите число B:");
int b = int.Parse(Console.ReadLine());

int pow = 1; 

for (int i = 1; i <= b; i++)
{
    pow = pow * a;
}

Console.WriteLine(pow);