//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];
Random ranNum = new Random();
Console.Write("Полученный массив: ");
void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        array[index] = ranNum.Next(1, 10);
        Console.Write($"{array[index]} ");
    }
}
FillArray(array);
Console.WriteLine();
int oddIndex = 0;
int sum = 0;

for (int index= 1; index < array.Length; index = index + 2)
{
    oddIndex = oddIndex + array[index];
    sum = sum + oddIndex;
}
Console.WriteLine("Сумма чисел массива стоящих на нечётных позициях : " + sum);