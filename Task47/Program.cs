/*Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.*/

double[,] CreateRandom2dArray()
{
 Console.Write("Введите количество строк: ");
 int rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите количество столбцов: ");
 int columns = Convert.ToInt32(Console.ReadLine());
 Console.Write("Ввод минимального значения: ");
 int minValue = Convert.ToInt32(Console.ReadLine());
    
 Console.Write("Ввод максимального значения: ");
 int maxValue = Convert.ToInt32(Console.ReadLine());
 double[,] array= new double[rows, columns];
 for(int i = 0; i< rows;i++)
 for(int j= 0; j < columns; j++)
 array[i,j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
 return array;
}
void Show2dArray(double[,] array)
{
 for(int i = 0; i < array.GetLength(0); i++)
      {
 for(int j = 0; j < array.GetLength(1); j++)
 Console.Write(array[i, j] + " ");
 Console.WriteLine();
      }
      Console.WriteLine();
}
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);