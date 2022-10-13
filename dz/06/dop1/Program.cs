// Напишите программу, которая задаёт массив из n элементов,
// которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите -1 для смещения влево, или 1 для смещения вправо");
int shift = int.Parse(Console.ReadLine());

//задаем массив 
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{ array[i] = new Random().Next(0, 10); }

//вывод массива в консоль
Console.WriteLine(string.Join(" ", array));

int last = array[n - 1];
int first = array[0];

//смещение влево
if (shift == -1)
{
    for (int i = 0; i < n - 1; i++)
    {array[i] = array[i + 1];}
    array[n - 1] = first;
}

//смещение вправо
if (shift == 1)
{
    for (int i = n - 1; i >= 1; i--)
    { array[i] = array[i - 1];}
    array[0] = last;
}

Console.WriteLine(string.Join(" ", array));