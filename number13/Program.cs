//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a % 10;
int c = 0;
int k = 0;
while (a >= 100)
{
    k = b;
    c = a / 10;
    a = c;
    b = a % 10;
    Console.Clear();
    Console.WriteLine(k);
    
}
while (k == 0)
{
    Console.WriteLine("третьей цифры нет");
    break;
}



