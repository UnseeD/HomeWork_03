﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите 5-ти значное число: ");
string N = Console.ReadLine();
if (N[0] == N[4])
{
    ;
} 
if (N[1] == N[3])
{
 Console.WriteLine("Число является полиндромом");
}
else Console.WriteLine("Число не является полиндромом");
