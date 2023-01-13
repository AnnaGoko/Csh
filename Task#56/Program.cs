// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine ("Задание 56: Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

int [] array = new int [n];
int[,] finalarray = RandomArray (m, n);
PrintArray(finalarray);
Summ (finalarray);
Print2Array(array);
Finder(array);

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

void Summ (int[,] finalarray)
{
int finalsumm = 0 ;
for (var i = 0; i < finalarray.GetLength(0); i++)
    {
        for (var j = 0; j < finalarray.GetLength(1); j++)
        {
           finalsumm += finalarray[i,j];
        }
        array[i] = finalsumm;
        
    }
    finalsumm = 0;
}

void Print2Array(int[] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
         Console.Write(array[i] + " ");
    }
}



void Finder (int[] array) { 
    int min = array[0]; 
    int k = 0;
    for (var i = 0; i < n; i++) 
{
    if (min > array[i])
    {
        min = array[i];
        k = i;
    }
}
Console.WriteLine($"Ответ: {(k+1)}" );
}
