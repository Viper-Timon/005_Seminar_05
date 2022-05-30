// Задача 31: Задайте массив из 12 элементов, 
//заполненный  случайными числами из промежутка 
// [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве 
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, 
// сумма отрицательных равна
// -20.

// Console.Write("Задайте размер массива -> ");
// int size = int.Parse(Console.ReadLine());
Console.Write("Задайте эл-ты массива  через пробел -> ");
// 4 5 6 8 9 5
int[] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(string.Join(' ', numsArr));

// int[] nums = new int[size];
int positive = 0;
int negative = 0;

// var newRnd = new Random();
// for (int i = 0; i < size; i++)
// {
//     nums[i] = newRnd.Next(-9, 10);
//     Console.Write(nums[i] + " ");
// }

for (int i = 0; i < numsArr.Length; i++)
{
    if (numsArr[i] >  0) positive += numsArr[i]; // positive = positive + nums[i]
    else negative += numsArr[i];
}
// Console.WriteLine();
Console.WriteLine($"Сумма положительных эл-ов массива = {positive}");
Console.WriteLine($"Сумма отрицательных эл-ов массива = {negative}");

