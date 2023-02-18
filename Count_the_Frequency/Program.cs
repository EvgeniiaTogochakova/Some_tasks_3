// Дан массив, заполненный положительными числами от 1 до N.
// Необходимо написать программу, которая укажет, сколько раз какое число встречается.
// Иными словами, необходимо построение частотного словаря.


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

void ArraySorting(int[]collection)
{
    int sorted_size = 0;
    int size = collection.Length;
    while (sorted_size < size-1)
        {
        int index = 0;
        while (index < (size-1-sorted_size))
        {
            if (collection[index] > collection[index+1])
            {
                int temp = collection[index];
                collection[index] = collection[index+1];
                collection[index+1] = temp;
            }
            index++;
        }
    sorted_size = sorted_size+1;
    }
}    

void FrequencyOfMinAndBeyond (int[]colle)
{
    int size = colle.Length;
    int index = 0;
    int count = 0;
    int limitation = 10;
    int min = 1;
    
    while (min <limitation)
    {
        while (index < size)
        { 
            if (colle[index] == min)
            {
            count++;
            }
            index++;
        }
        Console.Write (min);
        Console.Write ("-");
        Console.Write(count);
        Console.Write(" р.");
        Console.Write(" ");
        
    min = min+1;  
    count = 0;
    index = 0;
    }
}


int[]array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ArraySorting(array);
PrintArray(array);
Console.WriteLine();
FrequencyOfMinAndBeyond(array);

