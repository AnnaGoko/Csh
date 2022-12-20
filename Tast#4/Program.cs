//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine ("Задание 8: Введите число: ");
int num_ex4 = int.Parse(Console.ReadLine());
int num = 2;
if (num_ex4 % 2 == 1) {
    num_ex4 -= 1;
}
while (num != num_ex4){
    Console.WriteLine(num);
    num +=2;  
}