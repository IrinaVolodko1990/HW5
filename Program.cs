//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size = new Random().Next(5, 11);
int[] array = new int[size];
int count = 0;
void fillArray(int[] arr)
{
    Console.Write("Some array: [ ");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

int countEven(int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }

    return count;
}
fillArray(array);
Console.WriteLine();
Console.Write($"In array {countEven(array)} even number(s)");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int size = new Random().Next(4, 10);
Console.WriteLine($"Size of array: {size}");
int start = new Random().Next(-78, 0);
Console.WriteLine($"The lower bound of array: {start}");
int finish = new Random().Next(0, 78);
Console.WriteLine($"The upper bound of array: {finish}");
int[] array = new int[size];
void createArray(int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(start, finish);
        Console.Write($"{arr[i]} ");
    }
}
int countSumEvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
createArray(array);
Console.WriteLine();
Console.Write($"The sum of elements in odd positions = {countSumEvenNumbers(array)}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = new Random().Next(4, 10);
//Console.WriteLine($"Size of array: {size}");
double[] array = new double[size];

void createArray(double[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble(), 2);
        Console.Write($"{arr[i]} ");
    }
}

double searchMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double searchMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
createArray(array);
Console.WriteLine();
// Console.WriteLine($"Max = {searchMax(array)}");
// Console.WriteLine($"Min = {searchMin(array)}");
Console.WriteLine($"{searchMax(array)} - {searchMin(array)}  = {searchMax(array) - searchMin(array)}");

