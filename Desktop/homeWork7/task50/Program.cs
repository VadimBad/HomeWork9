// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.



Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i,j] = new Random().Next(0,100);
         Console.Write(numbers[i,j] + " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine("Позиция по строке");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Позиция по столбцу");
int b = Convert.ToInt32(Console.ReadLine());

if ((a < numbers.GetLength(0)) && (b < numbers.GetLength(1)))
{
    Console.WriteLine(numbers [a,b]);
}
else
{
    Console.WriteLine("Такого эл-та нет! ");
}
