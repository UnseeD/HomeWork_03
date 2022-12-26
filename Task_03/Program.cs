// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int x = 1; x <= N; x++)
{
        System.Console.Write($"{Math.Pow (x, 3)} ");
}