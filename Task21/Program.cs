/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Ввведите координаты двух точек: ");
Console.WriteLine("AX: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("AY: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("AZ: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("BX: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("BY: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("BZ: ");
int bz = Convert.ToInt32(Console.ReadLine());

double OurDistanse = Math.Round(Distance(ax, ay, az, bx, by, bz), 2, MidpointRounding.ToZero);
Console.WriteLine($"Дистанция координатов точек {ax} , {ay} , {az} и {bx} , {by} , {bz} равна: {OurDistanse}");

double Distance(int a1, int a2, int a3, int b1, int b2, int b3)
{
    double distance = Math.Sqrt(Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2) + Math.Pow((a3 - b3), 2));
    return distance;
}
