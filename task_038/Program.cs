// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Задача 038");
double[] array = new double[10];
SetArray(array);
PrintArray(array);
double max = array[0]; 
double min = array[0];

for (int i = 0; i < array.Length; i++)

    {
        if(array[i] > max) max = array[i];

        if(array[i] < min) min = array[i];
    } 

double raznitsa = max - min;
Console.WriteLine($"Разница между максимальным элементом {max} и минимальным элементом {min} массива, равняется: {raznitsa}");

void SetArray(double[] currentArray)
{
    Random rand = new Random();
    for (int i =0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.NextDouble()*100;
    }
}

void PrintArray(double[] currentArray)
{
    Console.WriteLine("Вывод массива на печать: ");
    for (int i =0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }

Console.WriteLine();
}

