// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Сколько чисел нужно ввести?");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Начинаем ввод...");
int numberBiggerThanNull = 0;
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Введите новое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) numberBiggerThanNull++;
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Чисел больше нуля " + numberBiggerThanNull);
*/

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Random rand = new Random();
int k1 = rand.Next(-10, 10);
int b1 = rand.Next(-10, 10);
int k2 = rand.Next(-10, 10);
int b2 = rand.Next(-10, 10);
int x;
int y;
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");
if (k1 != k2)
{
    x = (b2 - b1)/(k1-k2);
    y = k1 * x + b1;
    Console.WriteLine("x = " + x);
    Console.WriteLine("y = " + y);
}