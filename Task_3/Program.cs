// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GenerateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = Math.Round(rnd.NextDouble(), 2);
    }
    
    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
}

double difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
        max = array[i];
        if (min > array[i])
        min = array[i];
        i = i + 1;
    }
    return max - min;
}

double[] arr = GenerateArray(5);
PrintArray(arr);
System.Console.Write($"Разница между максимальным и минимальным элементами массива равна: {difference(arr)}");