// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 || number < -99)
{
    while (number > 999 || number < -999)
    {
        number /= 10;
    }
    int dig = number % 10;
    Console.WriteLine($"Третья цифра = {Math.Abs(dig)}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}