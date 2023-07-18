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

int countOdd(int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
   
    return count;
}
fillArray(array);
Console.WriteLine();
Console.Write($"In array {countOdd(array)} odd numbers");
