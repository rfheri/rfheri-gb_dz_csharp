// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//задаем массив
int[] array = new int[5];
int count = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);

//вывод массива в консоль
foreach (var item in array)
{
    Console.Write($"{item} ");
}

//основная логика
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        count += array[i];
    }
}

//ответ на задачу
Console.Write($"-> сумма чисел на нечетных позициях: {count}");