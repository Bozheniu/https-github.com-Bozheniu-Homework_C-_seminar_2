/* Задача 10: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого числа. */

int GetLastDigit(int number)
{
    return (number % 100) / 10;
}

int testNumber = 789;
Console.WriteLine(GetLastDigit(testNumber));