// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.22, 4.2,  1.15, 77.15, 65.2] –> 77.15 - 1.15 = 76
// [3.5,  7.1, 22.9,   2.3,  78.5] –> 76.2

Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] CreateArrayRandomDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble() * (max - min) + min;
    }
    return arr;
}

void OutputArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], round); // <– не потребуется эта строка
        if (i < arr.Length - 1) Console.Write($"{roundNum}, "); //   ∧
        else Console.Write(roundNum); // или ($"{arr[i]:F1}"), тогда |
    }
    Console.Write("]");
}

double MaxElementArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElementArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceMinMax(double max, double min) // DifferenceBetweenMaxAndMinElementsArray
{
    return max - min;
}

Console.Write("Введите размер массива (от 2 элементов): ");
int length = Convert.ToInt32(Console.ReadLine());
if (length < 2)
{
    Console.WriteLine();
    Console.WriteLine("Размер массива меньше 2 элементов.");
    return;
}

Console.Write("Введите количество знаков после запятой для округления (от 1 до 5): ");
int rounding = Convert.ToInt32(Console.ReadLine());
if (rounding < 1 || rounding > 5)
{
    Console.WriteLine();
    Console.WriteLine("Количество знаков после запятой меньше 1 или больше 5.");
    return;
}

Console.Write("Введите минимальное значение элементов массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
if (minValue > maxValue)
{
    Console.WriteLine();
    Console.WriteLine("Минимальное значение элементов массива больше максимального.");
    return;
}

// double[] array = { 3.5, 7.1, 22.9, 2.3, 78.5 }; // –> 76.2
// double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 }; // –> 77.15 - 1.15 = 76
double[] array = CreateArrayRandomDouble(length, minValue, maxValue);
double maxElementArray = MaxElementArray(array);
double minElementArray = MinElementArray(array);
double differenceMinMax = DifferenceMinMax(maxElementArray, minElementArray);
double result = Math.Round(differenceMinMax, rounding);

Console.WriteLine();
Console.Write("В массиве ");
OutputArrayDouble(array, rounding);
Console.WriteLine($" разница между максимальным и минимальным элементами = {result}");
