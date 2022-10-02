// Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями
// в диапазоне от -10 до 10 и найти максимальное значение среди них.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11);

foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.Write($"-> {array.Max()}");