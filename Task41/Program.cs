/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

int[] CreateAndFillArray (int num)
{
    int [] array = new int [num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array ;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("] => ");
}

int NumbersGreaterZero(int[] arr)
{
    int greaterZero = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) greaterZero = greaterZero + 1;
    }
    return greaterZero;
}


Console.WriteLine("Сколько чисел вы хотите ввести ? ");
int numberSize  = Convert.ToInt32(Console.ReadLine());

int [] userArray = CreateAndFillArray(numberSize);
PrintArray(userArray);
Console.Write (NumbersGreaterZero(userArray));