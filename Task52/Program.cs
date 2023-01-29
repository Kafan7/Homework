/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

    int[,] array= new int[rows, columns];
        for(int i = 0; i< rows;i++)
          for(int j= 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
         for(int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");

         Console.WriteLine();
      }
      Console.WriteLine();
}


double[] Arithmetic(int[,] array)
{
double[] newarray = new double[array.GetLength(1)];

for (int j = 0; j < array.GetLength(1); j++)

    {
    for (int i = 0; i < array.GetLength(0); i++)
        newarray[j] += array[i, j];
        newarray[j]=newarray[j] / array.GetLength(0);
    
    }
return newarray ;

}
void Show(double[] array)
{
      for(int i = 0; i < array.Length; i++)
      {
         Console.Write(Math.Round((array[i]), 2) + " ");
      }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] result = Arithmetic(myArray);
Show(result);