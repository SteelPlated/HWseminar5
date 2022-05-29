/*Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.WriteLine("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
var newRnd = new Random();
int sum = 0;
Console.Write("Массив: [");
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(0, 100);
    if (i%2==1)
    sum += array[i];
        
    if (i!=size-1)
    Console.Write(array[i] + ", ");
    else Console.Write(array[i] + "]");
   
}
Console.WriteLine();
Console.WriteLine($"Сумма нечетных чисел = {sum}");

