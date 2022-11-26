// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

int[] array = CreateRandomArray(10, 100, 1000);
Console.WriteLine($"{string.Join(" ", array)}");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}");