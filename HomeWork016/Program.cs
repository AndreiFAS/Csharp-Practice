// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива

int[] mass = new int [10];
int max = 0;
int min = 0;

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

int MaxMin(int[] col)
{
for (int i = 0; i < col.Length; i++)
    {
       if(col[i] > max) max = col[i];
       else if(col[i] < min) min = col[i];
    }
return max; 
return min;   
}

FillArray(mass);
PrintArray(mass);
Console.WriteLine();
max = mass[0];
min = mass[0];
MaxMin(mass);
Console.WriteLine($"Разницу между максимальным {max} и минимальным {min} элементами массива равна {max - min}");