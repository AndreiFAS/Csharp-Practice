// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int count = 2;
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
double T = Convert.ToDouble(N);

while (count < N)
{
    Console.WriteLine(count);
    count = count + 2;
};
if (N/2 == T/2) Console.WriteLine(N);