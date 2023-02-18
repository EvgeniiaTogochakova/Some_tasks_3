// Реализовать перемешивание массива

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[]collec)
{
    int count = collec.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collec[position]);
        position++;
    }
}

void ArrayShuffling(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        int random_position = new Random().Next(0,9);
        int help = collection[index];
        collection[index] = collection[random_position];
        collection[random_position] = help;
        index++;
    }
}
int[]array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ArrayShuffling(array);
PrintArray(array);
