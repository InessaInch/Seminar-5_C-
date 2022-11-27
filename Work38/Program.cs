/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива*/

double[] FillArrayRandomNumbers(int length, int minNumber, int maxNumber)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber + 1);
    }
    return array;
}

double getMaxNumber(double[] array)
{

    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];

        }
    }
    return maxNumber;
}

double getMinNumber(double[] array)
{

    double MinNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinNumber)
        {
            MinNumber = array[i];

        }
    }
    return MinNumber;
}
double getDiffNumber(double maxNumber, double MinNumber)
{

    double dif = maxNumber - MinNumber;
    return dif;
}

void PrintArray(double[] array)
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

double[] newArray = FillArrayRandomNumbers(5, -100, 100);
PrintArray(newArray);
double max = getMaxNumber(newArray);
double min = getMinNumber(newArray);
double difference = getDiffNumber(max, min);
Console.WriteLine($"Максимальный элемент = {max}, минимальный элемент  = {min}");
Console.WriteLine($"разница между максимальным и минимальным элементами: {difference}");



