// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
Console.WriteLine("Задание 25: Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int degree = int.Parse(Console.ReadLine());
double answer = num ;

if (degree > 0) {
for (int i = 0; i < degree-1; i++)
{
  answer *= num; 
}
Console.WriteLine($"{answer}");
}

else if (degree < 0) {
for (int i = 0; i < Math.Abs(degree)-1; i++)
{
  answer *= num; 
}
Console.WriteLine($"{1/answer}");
}

else{
  Console.WriteLine($"{1}");
}