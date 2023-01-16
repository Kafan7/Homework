/*Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.*/

Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел в числе {number} = {sumNumbers} ");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = num; i > 0;)
    {
        sum += i % 10;
        i = i / 10;
    }
    return sum;
}

