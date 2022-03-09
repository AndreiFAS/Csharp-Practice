// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string a = Convert.ToString(Console.ReadLine());
int b = Convert.ToInt32(a);

if (b > 99999 | b <= 9999 )
{
    Console.WriteLine("Неправильное число! Введите пятизначное!");
}
else
{
char[] array = a.ToCharArray();
Array.Reverse(array);
string c = new string(array);
if(a==c)
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Не полиндром");
}
}