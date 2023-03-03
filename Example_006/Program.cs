/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*///метод заполняющий заданный массив рандомными числами 
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

//метод выводящий массив в консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//метод считающий количество четных чисел
int CountNumbers(int[] Arr)
{
    int result = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int [] Array = new int[10];
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
int res = CountNumbers(Array);
Console.WriteLine(res);
