// Задайте одномерный массив из N элементов, заполненный случайными числами.
// Необходимо определить, в какой последовательности заданы элементы массива:
// по возрастанию, по убыванию, хаотично, или все элементы одинаковы.


//задаем массив 
int[] array = new int[3];
for (int i = 0; i < array.Length; i++)
{ array[i] = new Random().Next(0, 10); }

int more = 0;
int less = 0;
int equal = 0;

//вывод массива в консоль
Console.WriteLine(string.Join(" ", array));


// основная логика
for (int i = 1; i < array.Length; i++)
{
    if (array[i - 1] > array[i])
    {
        less++;
    }
    if (array[i - 1] < array[i])
    {
        more++;
    }
    if (array[i - 1] == array[i])
    {
        equal++;
    }
}


// ответ на задачу
if (less > 0 && more == 0 && equal == 0)
{
    Console.WriteLine("элементы массива расположены по убыванию");
}
else if (more > 0 && less == 0 && equal == 0)
{
    Console.WriteLine("элементы массива расположены по возрастанию");
}
else if (equal > 0 && less == 0 && more == 0)
{
    Console.WriteLine("все элементы одинаковы");
}
else
{
    Console.WriteLine("элементы массива расположены хаотично");
}