/* Дополнительная Задача 9
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Данное число {number} является кратным 7 и 23");
}
else
{
    Console.WriteLine($"Данное число {number} не является кратным 7 и 23");
}