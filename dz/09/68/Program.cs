// Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

int m = InputInt("Введите M ");
int n = InputInt("Введите N ");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int nod (int m, int n)
{
        if (n == 0)
                return m;
        else
                return nod (n, m % n);
}

Console.WriteLine($"наибольший общий делитель {nod(m, n)}");