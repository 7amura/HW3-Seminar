// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a string to Check Palindrome : ");
string name = Console.ReadLine()!;
string reverse = string.Empty;

foreach (char N in name)
{
     reverse = N + reverse;
}
if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Это число является палиндромом");
}
else
{
    Console.WriteLine("Это число не является палиндромом");
}
