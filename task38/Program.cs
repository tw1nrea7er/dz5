// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5];

void Array()
{
    double max = array[0];
    double min = 110.0; 
    double r = 0.0;
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(0, 50) + rand.NextDouble();
        
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        r = Math.Abs(max - min);
        Console.Write(Math.Round(array[i], 2) + " ");
    }
    Console.WriteLine();
    Console.WriteLine(Math.Round(max, 2));
    Console.WriteLine(Math.Round(min, 2));
    Console.Write(Math.Round(r, 2));
}
Array();