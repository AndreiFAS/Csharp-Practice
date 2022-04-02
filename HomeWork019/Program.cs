// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример: m = 3, n = 4. 0,5 7 -2 -0,2 1 -3,3 8 -9,9 8 7,8 -7,1 9

int line = 3;
int column = 4;
Random rnd = new Random();

void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-9, 10) + Math.Round(rnd.NextDouble(),1);
        }
    }
}

double[,] matrix = new double[line, column];
FillArray(matrix);
PrintArray(matrix);