// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76


int size = 10; // int size = int.Parse(Console.ReadLine());
float[] array = new float[size];
FillArray(array);
PrintArray(array);

Console.WriteLine("Максимальный элемент = " + FindMax(array));
Console.WriteLine("Минимальный элемент = " + FindMin(array));
float dif = FindMax(array) - FindMin(array);
Console.WriteLine("Разница между макс. и мин. = " + dif);

void FillArray(float[] arr1)
{
    int len = arr1.Length;
    var newRnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr1[i] = newRnd.Next(0, 100);
    }
}

void PrintArray(float[] arr2)
{
    int len2 = arr2.Length;
    for (int i = 0; i < len2; i++)
    {
        Console.Write(arr2[i] + " ");
    }
    Console.WriteLine();
}

float FindMax(float[] arr3) // Поиск значения максимального эл.
{
    float max = arr3[0];
    int len3 = arr3.Length;
    for (int i = 0; i < len3; i++)
    {
        if (arr3[i] > max) max = arr3[i];
    }
    return max;
}

float FindMin(float[] arr4) // Поиск значения минимального эл.
{
    float min = arr4[0];
    int len3 = arr4.Length;
    for (int i = 0; i < len3; i++)
    {
        if (arr4[i] < min) min = arr4[i];
    }
    return min;
}