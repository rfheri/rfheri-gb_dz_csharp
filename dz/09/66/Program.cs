// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int m = InputInt("Введите M ");
int n = InputInt("Введите N ");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Summ(int m, int n) {
    if(m > n) {
        return 0;
    }
    return m + Summ(m + 1, n);
}

Console.WriteLine($"Сумма {Summ(m, n)}");