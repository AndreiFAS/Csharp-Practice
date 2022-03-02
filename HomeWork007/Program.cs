// Задача 15: Дано число. Проверить кратно ли оно 7 и 23.

// int number = new Random().Next(10,1000);
// Console.WriteLine(number);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine("Кратно!");
}
else
{
    Console.WriteLine("Некратно!");
}