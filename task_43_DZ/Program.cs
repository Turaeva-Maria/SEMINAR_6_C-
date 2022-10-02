// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*Например, пользователь вводит k1, b1, k2, b2  - пусть 5, 2, 9, 4 (из примера задания). Тогда
x = (b2 - b1) / (k1 - k2) = 2/-4 = -0,5; 
y = k1*( -0,5) + b1 = - 5*0,5 + 2 = -2,5 + 2 = -0,5*/

Console.Clear();
Console.WriteLine("Введите первое значение первой координаты X1 прямой X: ");
double X1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение первой координаты X2 прямой X: ");
double X2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое значение второй координаты Y1 прямой Y: ");
double Y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение второй координаты Y2 прямой Y: ");
double Y2=Convert.ToInt32(Console.ReadLine());

double pointX = (X2 - X1) / (Y1 - Y2);
double pointY = (Y1 * X2 - Y2 * X1) / (Y1 - Y2);

if (Y1 != Y2)
{
    Console.WriteLine("");
    Console.WriteLine($"Прямые имеют точку пересечения ({pointX:f2} ; {pointY:f2})");
}
else
{
    if (X1 == X2)
    {
        Console.WriteLine("Прямые совпадают, а не являются параллельными");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
}

