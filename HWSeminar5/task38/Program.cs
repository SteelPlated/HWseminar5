/*Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
var newRnd = new Random();

double max =-999;
double min =9999;
double rezult;

Console.Write("Массив: [");
for (int i = 0; i < size; i++)
{//(от -99 до +99)Благодаря такому преобразованию, единичный промежуток "растягивается" до нужной вам длины и "передвигается" на нужное начало.
    //RandomObj.NextDouble() * (end - begin) + begin.
    array[i] = Math.Round (newRnd.NextDouble()* (99 + 99) - 99, 3); 
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
        
    if (i!=size-1)
    Console.Write(array[i] + "; ");
    else Console.Write(array[i] + "]");
   
}
rezult=Math.Round(max-min,3);

 
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами = {rezult}");