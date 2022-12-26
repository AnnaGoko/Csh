//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Задание 19: Введите число: ");
int num = int.Parse(Console.ReadLine());
if ((num % 10 == num / 10000) && ((num % 100) / 10 == (num / 1000) % 10)){
    Console.WriteLine($"Число {num} является полиндромом");
   //Console.WriteLine ($"{num % 10}, {num / 10000}, {(num % 100) / 10}, {(num / 1000) % 10 }");
}
else{
    Console.WriteLine($"Число {num} не является полиндромом");
    //Console.WriteLine ($"{num % 10}, {num / 10000}, {(num % 100) / 10}, {(num / 1000) % 10 }");
}
