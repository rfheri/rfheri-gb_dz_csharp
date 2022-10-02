// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

Console.WriteLine("Введите числа через запятую без пробела (4,5,2,0,34,...)");
string[] n = Console.ReadLine().Split(',');
Console.Write("массив: [");
foreach (var item in n)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");