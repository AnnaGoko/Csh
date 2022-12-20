//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Задание 2: Введите два числа для сравнения:");
Console.WriteLine ("Введите первое число: ");
int first_num_ex1 = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int second_num_ex1 = int.Parse(Console.ReadLine());
if (first_num_ex1 >= second_num_ex1) {
    Console.WriteLine("Наибольшее из двух чисел: {0}", first_num_ex1);
}
else {
    Console.WriteLine("Наибольшее из двух чисел: {0}", second_num_ex1);
}