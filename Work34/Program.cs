/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве*/

int[] FillArrayRandomNumbers(int length, int minDigit, int maxDigit)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minDigit, maxDigit + 1);
    }
    return array;
}

int GetNumberOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] newArray = FillArrayRandomNumbers(4, 100, 1000);
PrintArray(newArray);
int count = GetNumberOfEvenNumbers(newArray);
Console.WriteLine($"Количество четных чисел: {count} ");

