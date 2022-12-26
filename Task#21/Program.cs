//Задача 21:Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
Console.WriteLine("Задание 21: Введите число: ");
Console.WriteLine("Введите координаты первой точки: ");
int Ax = int.Parse(Console.ReadLine());
int Ay = int.Parse(Console.ReadLine());
int Az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
int Bx = int.Parse(Console.ReadLine());
int By = int.Parse(Console.ReadLine());
int Bz = int.Parse(Console.ReadLine());

//double length = Math.Pow (Math.Pow(Ax-Bx, 2) + Math.Pow(Ay-By, 2) + Math.Pow(Az-Bz, 2), 0.5);
Console.WriteLine($"Расстояние между точками А и В равна: {Math.Pow (Math.Pow(Ax-Bx, 2) + Math.Pow(Ay-By, 2) + Math.Pow(Az-Bz, 2), 0.5)}");
