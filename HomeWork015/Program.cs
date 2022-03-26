// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] mass = new int [10];
int count = 0;

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}

int NOTeven(int[] col)
{
for (int i = 0; i < col.Length; i++)
    {
       if(i % 2 != 0) count += col[i];
    }
return count;  
}



FillArray(mass);
PrintArray(mass);
Console.WriteLine();
NOTeven(mass);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {count}");