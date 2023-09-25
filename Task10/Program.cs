// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели неверное число, перезапустите программу");
}
else
{
    int secondDecimal = number / 10 % 10;
    Console.WriteLine($"Вторая цифра вашего числа - {secondDecimal}");
}