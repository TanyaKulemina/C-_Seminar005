/*
Задайте одномерный массив, заполненный случайными числами. Н
айдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


//метод заполняющий заданный массив рандомными числами 
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
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

//метод считающий сумму элементов, стоящих на нечётных позициях
int CountSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            result = result + arr[i];
        }
    }
    return result;
}

int [] array = new int[6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int sum = CountSum(array);
Console.WriteLine(sum);