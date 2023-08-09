// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

void Array()
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
        if (i % 2 != 0)
        {
            s += array[i];
        }
        Console.Write(array[i]+" ");
        
    }
    Console.WriteLine();
    Console.WriteLine(s);
}
Array();