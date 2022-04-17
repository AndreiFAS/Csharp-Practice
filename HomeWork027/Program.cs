// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 
// M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

Console.WriteLine("Введите число M и N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int NaturalSumm(int a, int b)
{
    if (a > b)
    {
        return 0;
    }
    else
    {
        return a + NaturalSumm(a + 1, b);
    }
}

Console.WriteLine($"{NaturalSumm(M, N)}");