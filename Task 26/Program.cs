/*Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbersLenght = NumbersLenght(number);
Console.WriteLine($"В числе {number} количество цифр = {numbersLenght} ");

int NumbersLenght(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count += 1;
    }
    return count;
}