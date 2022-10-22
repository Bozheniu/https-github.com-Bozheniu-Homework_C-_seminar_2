/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/

Console.Write("Введите число: ");
string number = Convert.ToString(Console.ReadLine());

if (number.Length > 2)
{
    Console.WriteLine($"Третья цифра: {number[2]}");
}
else
{
    Console.WriteLine(" Третьей цифры нет");
}