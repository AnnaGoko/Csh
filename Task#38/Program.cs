//Задание 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задание 38: задайте длину массива: "); 
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


Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {NewArray.Max()-NewArray.Min()}");
//void PrintArray(int [] NewArray ){
//    Console.WriteLine(string.Join( ", " , NewArray));
//}