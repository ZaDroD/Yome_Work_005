//34 Написать программу для замены элементов массива на противоположные.

int[] array = new int[10];
Random randNum = new Random();
void FillArray(int[] array)
{
    int position  = 0;
    while (position < array.Length)
    {
        array[position] = randNum.Next(-21,21);
        Console.Write($"{array[position]}  ");
        position ++;
    }
}
void ContraryNum(int[] array)
{
    for(int index = 0; index < array.Length; index ++)
    {
        array[index] = array[index] * -1;
        Console.Write($"{array[index]}  ");
    }
}
Console.WriteLine("Дан массив : ");
FillArray( array );
Console.WriteLine();
Console.WriteLine("Массив с противоположными знаками : ");
ContraryNum( array );