// Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

Console.WriteLine ("Задание 13: Введите число:");
int num = int.Parse(Console.ReadLine());
if (num < 99) {
    Console.WriteLine ("У числа {0} нет третьей цифры!", num);
}
else {
    while (num > 1000) {
        num /= 10;
    }
    Console.WriteLine ("Третья цифра: {0}", num % 10);
}
