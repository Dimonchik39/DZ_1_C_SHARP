﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите 2 числа. Мы определим, какое число больше.");
Console.Write("Введите первое число:  ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB) Console.WriteLine($"Первое число больше: {numA}");
if (numB > numA) Console.WriteLine($"Второе число больше: {numB}");
if (numA == numB) Console.WriteLine ("Числа равны");