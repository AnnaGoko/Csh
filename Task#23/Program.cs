// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Задание 23: Введите число: ");
int num = int.Parse(Console.ReadLine());
int length = num;
for ( num = 1; num < length; num++)
{
    Console.WriteLine($"{Math.Pow(num,3)}");
}
Console.WriteLine($"{Math.Pow(num,3)}");