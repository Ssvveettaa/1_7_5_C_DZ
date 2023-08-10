// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] –> 2

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

int CountEvenNumbersArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

if (length >= 0)
{
    // int[] array = { 345, 897, 568, 234 }; // –> 2
    int[] array = CreateArrayRandomInt(length, 100, 999);
    int result = CountEvenNumbersArray(array);

    Console.Write("В массиве ");
    OutputArray(array);
    Console.Write($" количество чётных чисел = {result}.");
}
else Console.WriteLine("Размер массива не может быть меньше 0.");
