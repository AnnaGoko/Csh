// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Задание 10: Введите число:");
int num = int.Parse(Console.ReadLine());
int third_num = (num % 100) / 10;
Console.WriteLine ("Третья цифра числа {0}: {1}", num, third_num);

