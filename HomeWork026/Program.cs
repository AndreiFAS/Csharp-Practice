// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N в обратном порядке. 
// M = 1; N = 5. -> «5, 4, 3, 2, 1»

Console.WriteLine("Введите число M и N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumber(int a, int b)
{
    if (a > b + 1)
    {
        Console.WriteLine("Неверно заданы числа!");
    }
    else if (a <= b)
    {
        PrintNaturalNumber(a + 1, b);
        Console.Write($" {a}");
    }
}

PrintNaturalNumber(M, N);