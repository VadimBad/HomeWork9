// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine ("Введите чило: ");

string str = Console.ReadLine();
int num = Convert.ToInt32(str);

if (num<100)
{
    Console.WriteLine ("Третьего числа нет");
}
else
{
    Console.WriteLine (str[2]);
}