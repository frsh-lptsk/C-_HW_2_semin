// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-х значное чило");
int A = int.Parse(Console.ReadLine());
int elment = A / 10 % 10;
Console.WriteLine("Вторая цифра числа = " +  elment);

