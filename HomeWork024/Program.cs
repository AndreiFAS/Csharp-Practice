// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] mass1 = new int[3, 4];
int[,] mass2 = new int[4, 1];
int[,] mass3 = new int[mass1.GetLength(0), mass2.GetLength(1)];

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

void ArrayComposition(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                mass3[i, j] += mass1[i, k] * mass2[k, j];
            }
        }
    }
}

FillArray(mass1);
PrintArray(mass1);
Console.WriteLine();
FillArray(mass2);
PrintArray(mass2);
Console.WriteLine();

if (mass1.GetLength(1) != mass2.GetLength(0))
{
    Console.WriteLine("Матрицы невозможно перемножить!");
}
else
{
    ArrayComposition(mass1, mass2);
    PrintArray(mass3);
}