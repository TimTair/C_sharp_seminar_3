// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты первой точки по оси X: ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Y: ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите коориднаты первой точки по оси Z: ");
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси X: ");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси Y: ");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите коориднаты второй точки по оси Z: ");
int Z2 = int.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow((X1 - X2),2) + Math.Pow((Y1 - Y2),2) + Math.Pow((Z1 - Z2),2));
Console.WriteLine($"Расстояние равно: {s}");


