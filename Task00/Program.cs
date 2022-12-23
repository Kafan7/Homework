/*Напишите программу, которая 
1. на вход принимает число и 
2. выдаёт его квадрат (число умноженное на само себя).*/

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
