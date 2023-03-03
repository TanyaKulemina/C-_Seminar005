/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}

bool Check(int number, int[] array)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            result = true;
            break;
        }
    }
    return result;
}

int number = GetNumber("Введите число");
int[] array = { 6, 7, 19, 345, 3 };
bool a = Check(number, array);
if(a) Console.WriteLine("да");
else Console.WriteLine("нет");