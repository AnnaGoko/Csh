//Задание 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задание 36: задайте длину массива: "); 
int length = int.Parse(Console.ReadLine());
int[] NewArray = RandomArray (length, -100, 101);
PrintArray(NewArray);

int[] RandomArray ( int size, int minn, int maxx){

    Random random = new Random ();
    int [] NewArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        NewArray[i] =  random.Next(minn, maxx); 
    }
    return NewArray;
}
int sum = 0;
int a = 1;
while (a < length)
{
    sum += NewArray[a];
    a+=2;
}

Console.WriteLine($"Сумма элементов массива: {sum}");
//void PrintArray(int [] NewArray ){
//    Console.WriteLine(string.Join( ", " , NewArray));
//}