// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int size = 10; // int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine("Кол-во четных эл. массива = " + FindEven(array));

void FillArray(int[] arr1)
{
    int len = arr1.Length;
    var newRnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr1[i] = newRnd.Next(100, 1000);
    }
}

void PrintArray(int[] arr2)
{
    int len2 = arr2.Length;
    for (int i = 0; i < len2; i++)
    {
        Console.Write(arr2[i] + " ");
    }
    Console.WriteLine();
}

int FindEven(int[] arr3) // подсчет кол-ва четных эл.массива
{
    int result = 0;
    int len3 = arr3.Length;
    for (int i = 0; i < len3; i++)
    {
        if (arr3[i] % 2 == 0) result++;
    }
    return result;
}
