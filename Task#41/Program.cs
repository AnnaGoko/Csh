//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
char[] SeparatingChars = {','};

string text = "1,2,3,4";
int[] words = text.Split(SeparatingChars);

Console.WriteLine($"{words.Length} ");

foreach (var word in words)
{
    Console.WriteLine($"{word}");
}