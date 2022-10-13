//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через запятую без пробела (4,5,2,0,34,...)");
string[] m = Console.ReadLine().Split(',').ToArray();
int count = 0;

//вывод массива в консоль
Console.Write(string.Join(" ", m));

for (int i = 0; i < m.Length; i++)
{
    if (int.Parse(m[i]) > 0)
    {
        count++;
    }

}

Console.Write($"-> {count}");