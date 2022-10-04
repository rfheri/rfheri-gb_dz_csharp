// Задайте одномерный массив, заполненный случайными числами.
// Из входного массива сформируйте массив с чётными и массив с нечётными
// значениями элементов входного массива. Найдите ср. арифметическое из полученных значений
// элементов массивов и выведите результат сравнения средних арифметических.


//первый массив 
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{ array[i] = new Random().Next(0, 100); }

// функция вычисления дочерних массивов
int[] SetSecondaryArray(int start)
{
    int count = 0;
    int[] fArray = new int[array.Length / 2];

    for (int i = start; i < array.Length; i += 2)
    {
        fArray[count] = array[i];
        count++;
    }
    return fArray;
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

int[] arrayOdd = SetSecondaryArray(0);
int[] arrayEven = SetSecondaryArray(1);

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
