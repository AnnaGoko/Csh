//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Задание 6: Введите число на проверку четности: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}