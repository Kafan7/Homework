/*Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.*/

int[] arrayOrigin = CreatArrayRndInt(10, -3, 5);
PrintArray(arrayOrigin);

int[] arrayCopy = CoppyArray(arrayOrigin);
PrintArray(arrayOrigin);

int[] CoppyArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

int[] CreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
