// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату Х первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y первой точки: ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z первой точки: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y первой точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х первой точки: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z первой точки: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

// 2D = корень((X1-X2)^2 + (Y1-Y2)^2)  3D = корень(2D^2 + (Z1-Z2)^2) = корень((корень((X1-X2)^2 + (Y1-Y2)^2))^2 + (Z1-Z2)^2)
// 3D = корень((X1-X2)^2 + (Y1-Y2)^2 + (Z1-Z2)^2)

double distance = Math.Sqrt(Math.Pow((X1-X2), 2) + Math.Pow((Y1-Y2), 2) + Math.Pow((Z1-Z2), 2));
Console.WriteLine($"Расстояние между точками - {distance:f3}");