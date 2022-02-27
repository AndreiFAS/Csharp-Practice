// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Здесь также подойдет решение как в Задаче 2. Но если чисел много больше трех удобнее будет формировать массив.

int[] array = { 0, 0, 0};
int max = 0;
int count = 0;
int index = 0;

while (count < array.Length)
{
    Console.Write("Введите число: ");
    array[count] = Convert.ToInt32(Console.ReadLine());
    count++;
}

while (index < array.Length)
{
    if (array[index] > max) max = array[index];
    index++;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);