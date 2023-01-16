/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.*/

Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число B: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int multiplicationNumbers = MultiplicationNumbers(number, number1);
Console.WriteLine($"Число {number} в степени {number1} = {multiplicationNumbers} ");

int MultiplicationNumbers(int num, int num1)
{
    int multiplication = num;
    for (int i = 2; i <= num1; i++)
    {
        multiplication *= num;
    }
    return multiplication;
}

