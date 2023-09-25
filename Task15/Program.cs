// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите порядковый номер дня недели: ");
int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Введено неверное значение, перезапустите программу");
}
else if (dayNumber < 6)
{
    Console.WriteLine($"{dayNumber} - это будний день");
}
else
{
    Console.WriteLine($"{dayNumber} - выходной день");
}