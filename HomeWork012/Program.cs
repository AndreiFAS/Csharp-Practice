// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Insert number ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Math.Abs(M);
string len = Convert.ToString(N);
int result = 0;
int count = 0;
for (int i = 1; i <= len.Length; i++)
{
    result = N % 10;
    count = count + result;
    N = N / 10;
}
Console.WriteLine($"Сумма цифр числа {M} равна {count}");
