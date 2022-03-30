// Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int count = 0;

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}

int ZeroPlus(int[] col)
{

    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Задайте количество чисел ");
int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(numbers);
PrintArray(numbers);
ZeroPlus(numbers);
Console.WriteLine();

if (count == 1)
{
    Console.WriteLine($"{count} число больше нуля.");
}
else if(count>1 & count<5)
{
    Console.WriteLine($"{count} числа больше нуля.");
}
else
{
    Console.WriteLine($"{count} чисел больше нуля.");
}