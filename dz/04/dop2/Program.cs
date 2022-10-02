// Напишите программу, которая задаёт 2 одномерных массива из N элементов
// которые заполняются случайными значениями в диапазоне от 1 до 10
// и находит среднее арифметическое элементов этих 2 массивов,
// далее от большего из получившихся средних арифметических отнимаем меньшее
// и округлённый до целого числа результат переводим в двоичную систему счисления.


Console.Write("введите количество элементов в 1 массиве: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("введите количество элементов во 2 массиве: ");
int n2 = int.Parse(Console.ReadLine());

int[] array1 = new int[n1];
int[] array2 = new int[n2];
double summ1 = 0;
double summ2 = 0;
double mid = 0;

for (int i = 0; i < n1; i++)
    array1[i] = new Random().Next(1, 11);

for (int i = 0; i < n2; i++)
    array2[i] = new Random().Next(1, 11);

for (int i = 0; i < array1.Length; i++)
    summ1 += array1[i];
double mid1 = summ1 / array1.Length;

for (int i = 0; i < array2.Length; i++)
    summ2 += array2[i];
double mid2 = summ2 / array2.Length;

if (mid1 > mid2)
{
    mid = mid1 - mid2;
}
else
{
    mid = mid2 - mid1;
}

foreach (var item in array1)
{
    Console.Write($"{item} ");
}
Console.WriteLine(" ");

foreach (var item in array2)
{
    Console.Write($"{item} ");
}

Console.WriteLine(" ");

Console.WriteLine($"{mid1}, {mid2}, {mid}");

Console.WriteLine($"округленоое среднее арифметическое: {Math.Round(mid)}");

Console.WriteLine($"результат в двоичной системе: {Convert.ToString((Convert.ToInt32(Math.Round(mid))), 2)}");