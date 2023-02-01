/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив*/

Random rnd = new Random();
while (true)
{
    int rows = IntRead("Введите кол-во строк двумерного массива: ");
    int columns = IntRead("Введите кол-во столбцов двумерного массива: ");

    int[,] arr = new int[rows, columns];
    FillArray(arr, 1, 10);
    Console.Clear();
    Console.WriteLine("Дан двумерный массив: ");
    PrintArray(arr);
    SortToLower(arr);
    Console.WriteLine();
    Console.WriteLine("Упорядоченный массив элементов по убыванию каждой строки: ");
    PrintArray(arr);

    Console.ReadKey();
    Console.Clear();
}


void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue - 1);
        Console.WriteLine();
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int IntRead(string stringNumber)
{
    Console.WriteLine(stringNumber);
    stringNumber = Console.ReadLine().Trim();
    while (!int.TryParse(stringNumber, out int number))
    {
        Console.WriteLine("Ошибка! Введите целое число!");
        stringNumber = Console.ReadLine().Trim();
    }
    Console.Clear();
    return Convert.ToInt32(stringNumber);
}


