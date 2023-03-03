/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
//метод заполняющий заданный массив рандомными числами 
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
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

//массив делающий умножение
int[] Multiplicate(int[] arr)
{
    int length = arr.Length;
    int[] newArr = null;
    if (length % 2 == 0) newArr = new int[length/2];
    else newArr = new int[length/2+1];
    for (int i = 0; i < newArr.Length; i++)
    {
        if (length % 2 == 1 && i == length/2)
        {
            newArr[i] = arr[i];
        }
        else
        {
            newArr[i] = arr[i] * arr[length-i-1];
        }
    }
    return newArr;
}

int[] array = new int[5];
FillArray (array);
PrintArray(array);
int[] newArray = Multiplicate(array);
Console.WriteLine();
PrintArray(newArray);
