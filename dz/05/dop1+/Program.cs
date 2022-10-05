// Задайте одномерный массив, заполненный случайными числами.
// Из входного массива сформируйте массив с чётными и массив с нечётными
// значениями элементов входного массива. Найдите ср. арифметическое из полученных значений
// элементов массивов и выведите результат сравнения средних арифметических.


//решение задачи через массив, незнаю насколько удачное


//первый массив 
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{ array[i] = new Random().Next(0, 100); }

//вторичные массивы
int[] arrayOdd = new int[array.Length / 2 + array.Length % 2]; //решение выглядит костылем, нужно для обработки первого массива с нечетным количеством элементов. иначе Index was outside the bounds of the array 
int[] arrayEven = new int[array.Length / 2];
int a = 0;
int b = 0;


// распределение четных и нечетных значений
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        arrayOdd[a] = array[i];
        a++;
    }
    else
    {
        arrayEven[b] = array[i];
        b++;
    }
}

// функция вычисления среднего арифметического 
double ArrayAverageSumm(int[] ArrayName)
{
    double summ = 0;
    for (int i = 0; i < ArrayName.Length; i++)
    { summ += ArrayName[i]; }
    double mid = summ / ArrayName.Length;
    return mid;
}

// функция вывода элементов массива в строку
void PrintArray(int[] array)
{
    foreach (var item in array) { Console.Write($"{item} "); }
    Console.WriteLine("");
}

//основные вычисления 

double midOdd = ArrayAverageSumm(arrayOdd);
double midEven = ArrayAverageSumm(arrayEven);

//вывод значений в консоль

PrintArray(array);
PrintArray(arrayOdd);
PrintArray(arrayEven);

Console.WriteLine(midOdd);
Console.WriteLine(midEven);

// ответ на задачу
if (midOdd > midEven)
{
    Console.Write($"{midOdd} > {midEven}");
}
else
{
    Console.Write($"{midOdd} < {midEven}");
}
