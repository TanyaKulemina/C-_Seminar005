/* 
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
//метод заполняющий заданный массив рандомными числами 1 и 0
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}
//метод выводящий массив в консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
//методы считающие сумму положительных и отрицательных чисел

int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

//создаем массив и применяем к нему методы
int [] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int a = SumPositive(array);
int b = SumNegative(array);
Console.WriteLine($"Сумма положительных чисел массива равна {a}, сумма отрицательных чисел массива равна {b}");
