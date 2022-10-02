// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// (Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон).

Console.Clear();
Console.WriteLine("Введите первое значение треугольника: X1");
double X1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе значение треугольника Y1: ");
double Y1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе значение треугольника Z1: ");
double Z1=Convert.ToInt32(Console.ReadLine());


if (X1 + Y1 > Z1 && Y1 + Z1 > X1 && X1 + Z1 > Y1)
    Console.WriteLine("Такой треугольник может существовать");
else
    Console.WriteLine("Такой треугольник НЕ может существовать");
