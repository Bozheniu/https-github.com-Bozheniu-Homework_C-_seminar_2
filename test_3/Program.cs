/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным. */

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine()!);

void WhatIsTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день недели является выходным");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Это не является днем недели");
    }
    else Console.WriteLine("Это рабочий день");
}

WhatIsTheDayOfTheWeek(dayNumber);
