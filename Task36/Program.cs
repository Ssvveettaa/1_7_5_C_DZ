// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [ 3,  7, 23, 12] –> 19
// [-4, -6, 89,  6] –>  0

int[] CreateArrayRandomInt(int size, int min, int max)
{
    int[] arr = new int[size];
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

void OutputArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int SumElementsOddPositionsArray(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

if (length >= 0)
{
    Console.Write("Введите минимальное значение элементов массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элементов массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    if (minValue > maxValue) (minValue, maxValue) = (maxValue, minValue);
    // Будем считать не существенным, что пользователь перепутал "max" и "min", главное обозначил границы интервала.

    // int[] array = { 3, 7, 23, 12 }; // –> 19
    // int[] array = { -4, -6, 89, 6 }; // –> 0
    int[] array = CreateArrayRandomInt(length, minValue, maxValue);
    int result = SumElementsOddPositionsArray(array);

    Console.Write("В массиве ");
    OutputArray(array);
    Console.Write($" сумма элементов, стоящих на нечётных позициях = {result}.");
}
else Console.WriteLine("Размер массива не может быть меньше 0.");
