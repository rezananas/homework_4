/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] CreatNewArray(int size_array, int min_value, int max_value)
{
    int [] array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        array[i] = new Random().Next(min_value, max_value + 1);
    }
    return array;
}

void ShowCreatedArray(int [] array)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное значение для диапазона случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное значение для диапазона случайных чисел: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreatNewArray(length, min, max);
ShowCreatedArray(array);