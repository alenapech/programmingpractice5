/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
Console.WriteLine("Задача 034");
int[] array = new int[10];
int count = 0; 
SetArray(array, 100, 999);
PrintArray(array);
 for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++; 
                
    }
 
 Console.WriteLine($"В массиве {count} положительных элементов");

void SetArray(int[] currentArray, int start, int end)
{
    Random rand = new Random();
    end++;
    for (int i =0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(start,end);
    }
}

void PrintArray(int[] currentArray)
{
    Console.WriteLine("Вывод массива на печать: ");
    for (int i =0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }

Console.WriteLine();
}



