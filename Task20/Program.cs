Console.WriteLine("Ввведите координаты двух точек: ");
Console.WriteLine("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double OurDistanse = Math.Round(Distance(xa, xb, ya, yb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Дистанция координатов точек {xa} , {xb} и {ya} , {yb} равна: {OurDistanse}");

double Distance(int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}