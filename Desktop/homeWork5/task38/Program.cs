// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

double min = Int32.MaxValue;
double max = Int32.MinValue;

void RandomArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
        if (array[i]>max)
        {
            max = array[i];
        }
        if (array[i]<min)
        {
            min = array[i];
        }
    }
}

RandomArray (array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(" ");
Console.WriteLine(max);
Console.WriteLine(" ");
Console.WriteLine(min);
Console.WriteLine("Разница:  " +(max-min));