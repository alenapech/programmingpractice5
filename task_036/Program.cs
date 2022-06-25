/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
*/

Console.WriteLine("Задача 036");
int[] array = new int[10];
int sum = 0; 
SetArray(array, 0, 10);
PrintArray(array);
for (int i = 1; i < array.Length; i +=2)

    {
        sum = sum + array[i];

    }

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равняется: {sum}");

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

