// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Пример: 1 4 7 2 5 9 2 3 8 4 2 4 Вывод -> 1 4 7 2 5 81 2 9 8 4 2 4

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] >= 0)
            {
                Console.Write($" {matr[i, j]} ");
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-9, 10);
        }
    }
}

void ExampleArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 != 0 & j % 2 != 0) { matr[i, j] = matr[i, j] * matr[i, j]; };
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ExampleArray(matrix);
PrintArray(matrix);