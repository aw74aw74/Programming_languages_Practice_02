// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int day = 0;
while (day < 1 || day > 7)
{
  Console.Write($"Введите номер дня недели от 1 до 7: ");
  day = int.Parse(Console.ReadLine());
}
if (day > 5) Console.WriteLine($"{day} -> Да");
else Console.WriteLine($"{day} -> Нет");