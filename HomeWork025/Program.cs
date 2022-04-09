// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).

int[,] mass = new int[4, 4];

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

void SpiralFillArray(int[,] array)
{
    array[0, 0] = 1;
    int i = 0;
    int j = 0;

    for (j = 1; j < array.GetLength(1); j++)
    {
        array[0, j] = array[0, j - 1] + 1;
    }
    for (i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1) - 1] = array[i - 1, array.GetLength(1) - 1] + 1;
    }
    for (j = array.GetLength(1) - 2; j >= 0; j--)
    {
        array[array.GetLength(0) - 1, j] = array[array.GetLength(0) - 1, j + 1] + 1;
    }
    for (i = array.GetLength(0) - 2; i > 0; i--)
    {
        array[i, 0] = array[i + 1, 0] + 1;
    }
    for (j = 1; j <= array.GetLength(1)-2; j++)
    {
        array[1, j] = array[1, j - 1] + 1;
    }
    for (i = array.GetLength(0) - 2; i < array.GetLength(0) - 1; i++)
    {
        array[i, array.GetLength(1) - 2] = array[i - 1, array.GetLength(1) - 2] + 1;
    }
    for (j = array.GetLength(1) - 3; j > 0 ; j--)
    {
        array[array.GetLength(0) - 2, j] = array[array.GetLength(0) - 2, j + 1] + 1;
    }
}

PrintArray(mass);
Console.WriteLine();
SpiralFillArray(mass);
PrintArray(mass);