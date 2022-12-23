/*Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

bool Weekend(int day)
{
    bool result;
    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
    
    return result;
}
Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool weekend = Weekend(dayNumber);
if (weekend) Console.WriteLine($"Да, этот день {dayNumber} является выходным");
else Console.WriteLine($"Нет, этот день {dayNumber} не является выходным");
