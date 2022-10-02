// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();

Console.WriteLine("Введите количество элементов массива (M): ");
int m = Convert.ToInt32(Console.ReadLine());


void InputArray(int[] array)
{
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        Console.Write($"Введите {i + 1}-й элемент массива:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
        i++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}


int[] array = new int[m];

InputArray(array);
Console.WriteLine("Вот массив: ");
PrintArray(array);

int res=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        res = res + 1;
    }
}

Console.WriteLine(" ");
Console.WriteLine("В массиве " + res + " элемент(а/ов) больше нуля");




