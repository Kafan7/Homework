/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4*/

int[,] CreateRandom2dArray()
{
 Console.Write("Введите количество строк: ");
 int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ввод минимального значения: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Ввод максимального значения: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int [rows, columns];
    for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
       array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;    
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.WriteLine();
    } 
    Console.WriteLine();
}
int Numbers(int[,] array,  int num1, int num2)
{
    int count = 0;
    if(num1 <= array.GetLength(0) && num2 <= array.GetLength(1))
    {
        count = array[num1, num2];
       Console.WriteLine(count);
    }
     else
     {
       Console.WriteLine("числа с такими индексами в массиве нет");
     }
     return count;
}
Console.Write("ВВедите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray();
ShowArray(myArray);
Numbers(myArray,a, b);