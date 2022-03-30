// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.
// x = (b2 - b1) / (k1 - k2) - в точке пересечения.

double b1;
double k1;
double b2;
double k2;
double x;
double y;
double check;

Console.WriteLine("Задайте число b1 ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте число k1 ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте число b2 ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте число k2 ");
k2 = Convert.ToDouble(Console.ReadLine());

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
check = k2 * x + b2;

Console.WriteLine();
Console.WriteLine($"Прямые пересекаются в точке ({x}, {y}). Проверка - {check}");

