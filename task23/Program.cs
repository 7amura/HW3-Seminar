﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter the nuber N ");
var number = Convert.ToInt32(Console.ReadLine());


for (var i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 3)},");
}