/*Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    Console.WriteLine($"Вторая цифра в числе {number} равна {number / 10 % 10}");
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}*/

int SecondDigit(int num)
{
    int result = num / 10 % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(number);
if (number >= 100 && number <= 999) Console.WriteLine($"Вторая цифра в числе {number} равна {secondDigit}.");
else Console.WriteLine("Вы ввели не трёхзначное число");
