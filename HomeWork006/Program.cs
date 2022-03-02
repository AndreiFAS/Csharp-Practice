// Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток.

int first = 0;
int second = 0;
Console.WriteLine("Введите первое число: ");
first = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите второе число: ");
second = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (first % second == 0)
{
    Console.WriteLine("Кратно!");
}
else
{
    Console.WriteLine("Остаток: " + (second - first));
}