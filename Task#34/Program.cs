//Задание 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Задание 34: задайте длинну массива: "); 
int length = int.Parse(Console.ReadLine());
int[] NewArray = RandomArray (length, 100, 999);
PrintArray(NewArray);

int[] RandomArray ( int size, int minn, int maxx){

    Random random = new Random ();
    int [] NewArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        NewArray[i] =  random.Next(minn, maxx +1 ); 
    }
    return NewArray;
}

int meter = 0;
for (int a = 0; a < length; a++)
{
    if (NewArray[a] % 2 == 0){
    meter+=1;
    }
}
Console.WriteLine($"Количество четных элементов массива: {meter}");
void PrintArray(int [] NewArray ){
    Console.WriteLine(string.Join( ", " , NewArray));
}