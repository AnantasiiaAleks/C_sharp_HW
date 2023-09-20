Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Максимальное число: " + number1 + ", минимальное число: " + number2);
}
else if (number1 == number2)
{
    Console.WriteLine("Поздравляем, эти числа равны, попробуйте еще раз!");
}
else
{
    Console.WriteLine("Максимальное числов: " + number2 + ", минимальное число: " + number1);
}