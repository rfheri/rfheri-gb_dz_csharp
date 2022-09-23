//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("введите число: ");
string a = Console.ReadLine();

if (a.Length <= 2)
{
    Console.Write("третьей цифры нет"); 
}
else
{
    Console.Write($"третья цифрa: {a.ToString()[2]}");
}