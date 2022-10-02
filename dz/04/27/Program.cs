// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

char[] n = Console.ReadLine().ToArray();
int a = 0;
foreach (var item in n) {
    a = Convert.ToInt32(Char.GetNumericValue(item))+a;
        }
Console.Write(a);