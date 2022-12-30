// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Задание 27: Введите число: ");
int num = int.Parse(Console.ReadLine());
int answer = 0;
while (num > 0) {
    answer = answer + num % 10;
    num /= 10;
}
Console.WriteLine($"{answer}");