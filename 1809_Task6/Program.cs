// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.Write("Напиши мне число: ");
int number = int.Parse(Console.ReadLine());

int remainder = number % 2;

if (remainder == 0)
{
    Console.Write("Молодец, " + number + " - это четное число.");
}
else
{
    Console.Write(number + " - это нечетное число, пополам без остатка не получится.");
}