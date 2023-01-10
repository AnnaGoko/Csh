//Задание 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine ("Задание 52: Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите интекс столбеца: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите интекс строки: ");
int m1 = int.Parse(Console.ReadLine());


int[,] finalarray = RandomArray (m, n);
PrintArray(finalarray);
finder (finalarray);
int[,] RandomArray ( int size_m, int size_n)
{

    Random random = new Random ();
    int [,] finalarray = new int [size_m, size_n];

    for (int i = 0; i < size_m; i++) 
    {
        for (int j = 0; j < size_n; j++) 
        {
            finalarray[i,j] = random.Next(-100, 100); 
    }
    }
return finalarray;
}

void PrintArray(int[,] finalarray)
{
    for (var i = 0; i < finalarray.GetLength(0); i++)
    {
        for (var j = 0; j < finalarray.GetLength(1); j++)
        {
            Console.Write(finalarray[i,j] + " ");
        }
        Console.WriteLine();
    }
}


void finder (int[,] finalarray)
{
if ((m-1 >= m1) && (n-1 >= n1) && (m > 0) && (n > 0)){
    Console.Write(finalarray[m1,n1]);
    }
else {
    Console.WriteLine("Такого числа в массиве нет");
    }
}