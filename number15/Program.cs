//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите порядковый номер дня недели что бы узнать является ли он выходным: ");
int wd = int.Parse(Console.ReadLine()!);
//Дополнительный блок.
//if (wd > 7 && wd < 1)
//{
//    Console.WriteLine("Ты что то путаешь, в неделе 7 дней, а не больше, перезапусти программу и попробуй еще раз!");
//}
if (wd < 6)
{
    Console.WriteLine("Нет");
}
if (wd > 5 && wd < 8)
{
    Console.WriteLine("Да");
}