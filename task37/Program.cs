Console.Clear();

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array2 = RandArray(4);
PrintArray(array2);
double dif = FindDifference(array2);
Console.WriteLine();
Console.WriteLine($"{dif}");


double[] RandArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
    return array;

}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

double FindDifference(double[] arrFind)
{

    double max = 0;
    double min = arrFind[0];
    for (int i = 0; i < arrFind.Length; i++)
    {

        if (arrFind[i] > max)
        {
            max = arrFind[i];
        }

        if (arrFind[i] < min)
        {
            {

                min = arrFind[i];
            }
        }
    }

    return max - min;
}