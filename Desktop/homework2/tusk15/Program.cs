// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Данную задачу можно решить и через массив.
// int num = new Random().Next (1, 8);


Console.WriteLine ("Введите чило: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num<1 || num>7)
{
    Console.WriteLine ("Дня недели не существует");
}
else if (num==6 || num==7)
{
    Console.WriteLine ("Выходной");
}
else
{
    Console.WriteLine ("Будний день");
}