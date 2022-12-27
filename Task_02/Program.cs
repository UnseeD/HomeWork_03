// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Введите координаты точки A: ");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B: ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());
double S = Math.Sqrt (Math.Pow(X2 - X1,2) + Math.Pow(Y2 - Y1,2) + Math.Pow(Z2 - Z1,2));
System.Console.WriteLine(S);
