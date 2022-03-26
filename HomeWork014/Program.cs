// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

int[] mass = new int [10];
int count = 0;

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 1000);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}

int even (int[] col)
{
for (int i = 0; i < col.Length; i++)
    {
       if((col[i] % 2) == 0) count++;
    }
return count;  
}



FillArray(mass);
PrintArray(mass);
Console.WriteLine();
even(mass);
Console.WriteLine($"количество чётных чисел в массиве {count}");
