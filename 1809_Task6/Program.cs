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