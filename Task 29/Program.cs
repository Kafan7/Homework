/*Напишите программу, которая задаёт
массив из 8 элементов, заполненный
псевдослучайными числами и выводит их на экран.*/

int[] array = new int[8];

void SizeArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

Console.WriteLine("Вывод массива из 8 элементов заполненный псевдослучайными числами : ");
SizeArray(array);
PrintArray(array);