// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine ("Задание 15: Введите число:");
int data = int.Parse(Console.ReadLine());
if (data < 6 && data != 0){
    Console.WriteLine ("{0} день недели не является выходным!", data); 
}
else if (data > 5 && data < 8 ){
    Console.WriteLine ("{0} день недели является выходным!", data);
}
else {
    Console.WriteLine ("В неделе 7 дней( Как бы грустно это не было, попробуйте еще раз!");
}