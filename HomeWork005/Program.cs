// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int Number = 0;
Console.WriteLine("Введите трехзначное число: ");
Number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (Number >= 100 & Number <= 999) 
{
  Number /= 10;
  int second = Number % 10;
  Console.WriteLine("Вторая цифра - " + second);
} 
else 
{
  Console.WriteLine("Неправильное число!");
}