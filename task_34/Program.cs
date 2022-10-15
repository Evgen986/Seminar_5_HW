/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
             Напишите программу, которая покажет количество чётных чисел в массиве.
             [345, 897, 568, 234] -> 2
*/
Console.Clear();

int[] array = GetArray(6);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве = {CountEvenNum(array)}");


int[] GetArray(int sizeArray)
{
    int[] arr = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        arr[i] = new Random().Next(100, 1000);
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

int CountEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}