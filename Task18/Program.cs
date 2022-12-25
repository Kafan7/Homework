Console.WriteLine("Введите номер четверти ");

string quarter = Console.ReadLine();
string result = QuarterCoordinates(quarter);
Console.WriteLine(result);

string QuarterCoordinates(string number)
{
    if (number == "1") return "x > 0; y > 0";
    if (number == "2") return "x < 0; y > 0";
    if (number == "3") return "x < 0; y < 0";
    if (number == "4") return "x > 0; y < 0";
    return "Неверный номер четверти";
}







