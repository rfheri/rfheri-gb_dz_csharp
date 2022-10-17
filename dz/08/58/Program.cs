// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int size = InputInt("размер матриц: ");
int[,] matr1 = new int[size, size];
int[,] matr2 = new int[size, size];
FillRandom(matr1);
FillRandom(matr2);
int[,] result = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            result[i, j] = result[i, j] + (matr1[i, k] * matr2[k, j]);
        }
    }
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 8);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}


Console.WriteLine("Матрица 1:");
PrintArray(matr1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
PrintArray(matr2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(result);