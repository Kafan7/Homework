/* Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да*/

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int square = secondNumber * secondNumber;
if(square == firstNumber)
{
    Console.WriteLine("первое число является квадратом второго");
}
else
{
    Console.WriteLine("первое число не является квадратом второго");
}