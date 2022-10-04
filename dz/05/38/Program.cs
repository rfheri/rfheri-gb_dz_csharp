// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double[7];

//задаем массив чисел с плавающей запятой в диаппазоне -10..10
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().NextDouble() * (10-(-10))+(-10);


//вывод массива в консоль
foreach (var item in array)
{
    Console.Write($"{item} ");
}

/*Console.WriteLine("");
Console.WriteLine(array.Max());
Console.WriteLine(array.Min()); */

//ответ на задачу
Console.WriteLine($"-> разница между максимальным и минимальным элементом: {array.Max() - array.Min()}");
