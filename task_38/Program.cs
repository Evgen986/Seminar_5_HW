/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
             [3 7 22 2 78] -> 76
*/
Console.Clear();

int[] array = GetArray(6, -50, 50);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {FindMaxNumArray(array) - FindMinNumArray(array)}");

int[] GetArray(int sizeArray, int minValue, int maxValue)
{
    int[] arr = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i] + "]");
        }
    }
    Console.WriteLine();
}

int FindMinNumArray(int[] arr)
{
    int min = arr[0];
    foreach (int el in arr)
    {
        if (el < min)
        {
            min = el;
        }
    }
    // Console.WriteLine("min = " + min);
    return min;
}

int FindMaxNumArray(int[] arr)
{
    int max = arr[0];
    foreach (int el in arr)
    {
        if (el > max)
        {
            max = el;
        }
    }
    // Console.WriteLine("max = " + max);
    return max;
}