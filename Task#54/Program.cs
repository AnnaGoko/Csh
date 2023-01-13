// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine ("Задание 54: Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

int sort = 0;
int[,] finalarray = RandomArray (m, n);
PrintArray(finalarray);
Console.WriteLine ("________");
SortArray (finalarray);
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

void SortArray(int[,] finalarray)
{
    
    for (int i = 0; i < finalarray.GetLength(0); i++)
{
    for (int j = 0; j < finalarray.GetLength(1); j++)
    {
        if (j+1 < n){
        if (finalarray[i,j] < finalarray[i,j+1])
        {
            sort = finalarray[i,j];
            finalarray[i,j] = finalarray[i,j+1];
            finalarray[i,j+1] = sort;
        }
        sort = 0;
        }
        else {
            if (finalarray[i,j] > finalarray[i,j-1]){
                sort = finalarray[i,j];
                finalarray[i,j-1] = finalarray[i,j];
            }
            sort = 0;
        }
    }
}
        
    }
