// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];
int index = 0;
int even = 0;
int odd = 0;
void FillArray()
{
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(100, 1001);
        Console.Write($"{array[i]} ");
    }
}
FillArray();
while (index < array.Length)
{
    if (array[index] % 2 == 0)
    {
        even ++;
    }
    else
    {
        odd ++;
    }
    index ++;
}
Console.WriteLine();
Console.Write("Колличество чётных числел = " + odd);
Console.WriteLine();
Console.Write("Колличество нечётных числел = " + even);