/*Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int ThirdDigitOfNumber(int num)
{
    int result;
    if (num <= 99)
        result = -1;
    else
    {
        while (num > 999)
            num = num / 10;
        result = num % 10;
    }
    
    return result;
}
Console.Write("Ввведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ThirdDigitOfNumber(number);
if (thirdDigit > -1) Console.WriteLine($"Третья цифра в числе {number} будет {thirdDigit}");
else Console.WriteLine("Третьей цифры нет");