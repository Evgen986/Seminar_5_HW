/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
             [3, 7, 23, 12] -> 19
             [-4, -6, 89, 6] -> 0
*/
Console.Clear();

int[] array = GetArray(6, -50, 50);
PrintArray(array);
Console.WriteLine($"Сумма чисел в нечетных ячейках массива = {SumNumOddIndex(array)}");

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

int SumNumOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}