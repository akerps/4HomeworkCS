/* Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]    */

int[] array = new int[8];

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,100);
        index++;
    }
}

void printArray(int[] col)
{
    int count = 0;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

FillArray(array);
printArray(array);

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i]);
        if (i < array.Length -1)
    {
        Console.Write(", ");
    }
}

Console.Write(" -> [");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length -1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine("]");