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

int[] array = CreatArrayRndInt(4, -9, 9);
PrintArray(array);

bool NumArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}

Console.Write("Ввведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool numArray = NumArray(array, number);
if (numArray)
{
    Console.Write($"Число {number} есть в массиве ");
    PrintArray(array);
}
else
{
    Console.Write($"Число {number} нет в массиве ");
    PrintArray(array);
}



