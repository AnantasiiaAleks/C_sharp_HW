// Задача 4: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Напишите сюда первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Теперь еще одно число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Я хочу еще одно число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("Найдено максимальное число. ЭТО: " + max + "!");
