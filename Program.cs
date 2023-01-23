// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.


int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result [i] = new Random().Next(start, end+1);
    }
    return result;
}

void printArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int FindEvens(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {result ++;}
    }
    return result;
}
int[] array = generateArray(4, 100, 999); // В задании сказано "задайте массив". Решил зафиксировать количество элементов 4, как в примере условия.
printArray(array);
int evenCount = FindEvens(array);
Console.WriteLine($"Количество чётных чисел в массиве = {evenCount}.");