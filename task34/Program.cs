// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int arraylength = UserInput("Длина массива: "); // ввод длины массива

int arraymin = UserInputMinMax("Введите минимальное значение (не менее 100): ");
int arraymax = UserInputMinMax("Введите максимальное значение (не более 1000): "); ;
EqualityMinMax(arraymin, arraymax); // Сообщение об ошибке
// прерываем работу программы
int[] userarray = RandArray(arraylength, arraymin, arraymax); // заполняем массив

PrintArray(userarray); // печать массива

int evennumber = FindEven(userarray); // ищем четные
Console.WriteLine();
Console.WriteLine($"Четных чисел: {evennumber}");  // печатаем количество четных

// Функция для ввода массива
int UserInput(string user)
{
    Console.Write(user);
    int input = int.Parse(Console.ReadLine());
    return input;
}

// Функция для ввода диапазона (минимальное, максимальное)
int UserInputMinMax(string user)
{
    Console.Write(user);
    int minmax = int.Parse(Console.ReadLine());
    while (minmax < 99 || minmax > 1000)
    {
        Console.WriteLine("Внимание! Число не трехзначное! Повторите ввод: ");
        minmax = int.Parse(Console.ReadLine());
    }
    return minmax;
}

//Проверка диапазона
void EqualityMinMax(int minNum, int maxNum)
{
    string message;
    if (minNum > maxNum)
    {
        Console.WriteLine("Ошибка ввода диапазона! 'Минимальное' значение должно быть меньше 'Максимального'");
        Environment.Exit(0);
    }

}

// случайный массив
int[] RandArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];// объявляем массив из length элементов
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return (array);
}

//печать массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.WriteLine("]");
}

// поиск чётных чисел
int FindEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

