// Вид 1

// void Method1 ()
// {
//     Console.WriteLine("Сделано в СССР.");
// }
// Method1();

// Вид 2

// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Вывод текста");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);  // можно менять местами если указываем msg: и count: , а не указывая нужно соблюдать порядок ("Текст", 4)

// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);