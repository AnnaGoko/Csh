//Задание 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine ("Задание 47: Введите количество столбцов массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine());


int[,] finalarray = RandomArray (m, n);
PrintArray(finalarray);
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

