// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Задание 4: Введите три числа для сравнения:");
Console.WriteLine ("Введите первое число: ");
int first_num_ex2 = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int second_num_ex2 = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третий число: ");
int third_num_ex2 = int.Parse(Console.ReadLine());
if (first_num_ex2 >= second_num_ex2 && first_num_ex2 >= third_num_ex2) {
    Console.WriteLine("Наибольшее из трех чисел: {0}", first_num_ex2);
}
else if (second_num_ex2 >= first_num_ex2 && second_num_ex2 >= third_num_ex2) {
    Console.WriteLine("Наибольшее из трех чисел: {0}", second_num_ex2);
}
else {
    Console.WriteLine("Наибольшее из трех чисел: {0}", third_num_ex2);
}
