// Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int m = InputInt("Введите M ");
int n = InputInt("Введите N ");

void Recursion(int m, int n) {
 if (m <= n) 
 {
    if (m%2==0) {
        Console.Write($"{m} ");
    }
    m++;
    Recursion(m,n);
 }

}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

Recursion(m, n);