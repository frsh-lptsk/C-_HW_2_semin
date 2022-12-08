// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите любое число = ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
int A = n;
int count = 0;

while ( A > 0)
{
    A /= 10;
    count++;
}
if ( count -3 >= 0 )
{
    while ( count -3 > 0 )
    {
        n = n / 10;
    count--;
    }
    Console.WriteLine($"Третья цифра числа = {n % 10} ");
}
else
{
    Console.WriteLine("Третьей цифры нет ");
}