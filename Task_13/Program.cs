﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"{num} -> ");
while (num > 999) num = num / 10;
if (num < 100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(num % 10);