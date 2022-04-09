// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] mass = new int[5, 8];
int lineNumber = 1;
int minSumm = 0;

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int LinesSumm(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        minSumm += array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumm = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSumm += array[i, j];
        }
        if (tempSumm < minSumm)
        {
            minSumm = tempSumm;
            lineNumber = i + 1;
        }
    }
    return lineNumber;
    return minSumm;
}

FillArray(mass);
PrintArray(mass);
LinesSumm(mass);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов - {minSumm} на {lineNumber} строке");