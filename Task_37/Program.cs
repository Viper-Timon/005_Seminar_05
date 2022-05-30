// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива -> ");
int len = int.Parse(Console.ReadLine());
Console.WriteLine($"деление на %2 = {len % 2}");

int[] array = new int[len];
var newRnd = new Random();

// заполнение
for (int i = 0; i < array.Length; i++)
{
    array[i] = newRnd.Next(1, 11);
    Console.Write(array[i] + " ");
}

Console.WriteLine();


//                                          попробовать упростить 
int size2 = array.Length / 2;

if (len % 2 == 1)
{
    Console.Write("[");
    size2++;
    int[] col1 = new int[size2];
    for (int i = 0; i < size2; i++)
    {
        if (i == size2 - 1)
        {
            col1[i] = array[i];
            Console.Write(col1[i] + "]");
        }
        else
        {
            col1[i] = array[i] * array[(len - 1) - i];
            Console.Write(col1[i] + " ");
        }

    }

    Console.WriteLine();
}

else
{
    Console.Write("[");
    for (int i = 0; i < size2; i++)
    {
        int[] col1 = new int[size2];
        col1[i] = array[i] * array[(len - 1) - i];
        //печать с условием
        if (i == size2 - 1) Console.Write(col1[i] + "]");
        else Console.Write(col1[i] + " ");
    }
    Console.WriteLine();
}
