/*Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int kol=0;
var newRnd = new Random();
Console.Write("Массив: [");
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(100, 999);
    if (array[i]%2==0) 
        kol++;
    if (i!=size-1)
        Console.Write(array[i] + ", ");
    else Console.Write(array[i] + "]");

}

Console.WriteLine("-> "+kol);