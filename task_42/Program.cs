// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());


string? s = String.Empty;

while (n > 0)
{
    int x = n % 2;
    s = Convert.ToString(x) + s;
    n = n / 2;
}
Console.WriteLine(s);

n++;

 /*Console.Clear();


string f(int n)
{
    if (n == 0)
        return "";
    return f(n / 2) + Convert.ToString(n % 2);
}


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/