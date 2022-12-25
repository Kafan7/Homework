Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    TableSquare(number);
}
else Console.WriteLine("Не натуральное число");

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 4} {Math.Pow(count, 2), 4}");
        count++;
    }
}
