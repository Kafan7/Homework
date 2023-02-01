/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив*/

Random rnd = new Random();
while (true)
{
    int rows = IntRead("Введите кол-во строк двумерного массива: ");
    int columns = IntRead("Введите кол-во столбцов двумерного массива: ");

    if (rows == 0 || columns == 0)
        continue;


    int[,] arr = new int[rows, columns];
    FillArray(arr, 1, 10);
    Console.Clear();
    Console.WriteLine("Дан двумерный массив: ");
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine("Номер строки двумерного массива с наименьшей суммой элементов: ");
    NumberRowMinSumElements(arr);

    Console.ReadKey();
    Console.Clear();
}

// Метод вывода номера строки (не индекса) с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array)
{
    int minRowTemp = 0;
    int sumRowTemp = 0;
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumRowTemp += array[i, j];

        if (i == 0)
        {
            minRowTemp = sumRowTemp;
            sumRowTemp = 0;
        }
        else
        {
            if (sumRowTemp < minRowTemp)
            {
                minRowTemp = sumRowTemp;
                minSumRow = i;
            }
            sumRowTemp = 0;
        }
    }
    Console.Write($"{minSumRow + 1} строка");
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