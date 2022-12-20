// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Задание 4: Введите три числа для сравнения:");
Console.WriteLine ("Введите первое число: ");
int first_num = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int second_num = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третий число: ");
int third_num = int.Parse(Console.ReadLine());
if (first_num >= second_num && first_num>= third_num) {
    Console.WriteLine("Наибольшее из трех чисел: {0}", first_num);
}
else if (second_num >= first_num && second_num >= third_num) {
    Console.WriteLine("Наибольшее из трех чисел: {0}", second_num);
}
else {
    Console.WriteLine("Наибольшее из трех чисел: {0}", third_num);
}
