// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.WriteLine("Задание 29: Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());
int [] NewArray = new int [length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Введите {0} элемент массива: ", i);
    NewArray[i] = int.Parse(Console.ReadLine());          
}

Console.WriteLine ("NewArray = { ");

for (int a = 0; a < length; a++)
{
    Console.WriteLine (NewArray [a]);
}
Console.WriteLine ("}");