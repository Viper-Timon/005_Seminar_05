// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введитие искомое число");
int find = int.Parse(Console.ReadLine());
int size = 10;
int[] array = new int [size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 21);
    Console.Write(array[i] + " ");
}
string txtOut = " -> Нет";
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == find) 
    {
        txtOut = "Да";
        break;
    }
    
}
Console.WriteLine(txtOut);