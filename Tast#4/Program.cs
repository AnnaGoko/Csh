//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine ("Задание 8: Введите число: ");
int num = int.Parse(Console.ReadLine());
int even = 2;
if (num % 2 == 1) {
    num -= 1;
}
while (even != num){
    Console.WriteLine(even);
    even +=2;  
}
Console.WriteLine(even);