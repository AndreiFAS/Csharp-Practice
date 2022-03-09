// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int i = 1;

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    while (i <= N)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}
else
{
    while (N <= i)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i--;
    }
}