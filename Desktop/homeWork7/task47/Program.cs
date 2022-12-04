// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i,j] = new Random().NextDouble();
        numbers[i,j] +=new Random().Next (-10,10);
        numbers[i,j] = Math.Round(numbers[i,j], 2);
        Console.Write(numbers[i,j]+" ");
    }
    Console.WriteLine(" ");
}
