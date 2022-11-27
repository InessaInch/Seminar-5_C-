/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях*/
int[] FillArrayRandomNumbers(int length, int minDigit, int maxDigit)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minDigit, maxDigit + 1);
    }
    return array;
}

int getSumOfElementsInNegativeIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2! == 0)
        {
            sum += array[i];
        }
    }
    return sum;
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

int[] newArray = FillArrayRandomNumbers(8, -100, 100);
PrintArray(newArray);
int SumOfElementsInNegativeIndex = getSumOfElementsInNegativeIndex(newArray);
Console.WriteLine($"Сумма элементов нечетных позиций: {SumOfElementsInNegativeIndex} ");
