Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "андрей")
{
    Console.WriteLine("Здрав буди боярин!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}