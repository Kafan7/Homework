int[] CreatArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-20, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int[] CountElements(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
        else newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreatArray(7);
PrintArray(array);
int[] newArray = CountElements(array);
Console.WriteLine();
PrintArray(newArray);







