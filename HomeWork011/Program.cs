// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Insert number A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert number B ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Проверка: {Math.Pow(A, B)}");
double result = 1;
if (B > 0)
{
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    Console.WriteLine($"{result}");
}
else 
{
    for (int i = B; i < 0; i++)
    {
        result *= A;
    }
    result = 1 / result;
    Console.WriteLine($"{result}");
}
