/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

//метод заполняющий заданный массив рандомными числами 
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,999);
    }
}

//метод, осуществляющий поиск

int Find(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10  && arr[i] <= 99)
        {
            result++;
        }
    }
    return result;
}

int[] array = new int[123];
FillArray(array);
int sum = Find(array);
Console.WriteLine(sum);
