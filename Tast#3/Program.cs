//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Задание 6: Введите число на проверку четности: ");
Console.WriteLine ("Введите число: ");
int num_ex3 = int.Parse(Console.ReadLine());
if (num_ex3 % 2 == 0) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}