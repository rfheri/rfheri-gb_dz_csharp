//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("введите пятизначное число: ");
string a = Console.ReadLine();

if (a.Length != 5)
{
    Console.WriteLine("это не пятизначное число");
}
else
{
    if (a == new string(a.Reverse().ToArray()))
    {
        Console.WriteLine("это палиндром");
    }
    else
    {
        Console.WriteLine("это не палиндром");
    }

}


