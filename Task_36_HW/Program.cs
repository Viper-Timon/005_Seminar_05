// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int size = 10; // int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine("Сумма эл., стоящих на нечёт. поз. = " + FindSumOddPos(array));

void FillArray(int[] arr1)
{
    int len = arr1.Length;
    var newRnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr1[i] = newRnd.Next(-99, 100);
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

int FindSumOddPos(int[] arr3) // подсчет суммы значений эл. на нечетной позиции
{
    int result = 0;
    int len3 = arr3.Length;
    for (int i = 0; i < len3; i++)
    {
        if (i%2 != 0) result+=arr3[i];
    }
    return result;
}
