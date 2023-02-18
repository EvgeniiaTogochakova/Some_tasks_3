//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125 

void FillArrayInOrder(double[]collection)
{
    int length = collection.Length;
    int index = 0;
    int min = 1;
    while (index < length)
    {
        collection[index] = min;
        
        index++;
        min++;
    }    
}

void CubicArray (double[]collec)
{
    int length = collec.Length;
    int index = 0;
    double instead = 1;
    while (index < length)
    {
        instead = Math.Pow (collec[index],3);
        collec[index] = instead;
        index++;
    }
}
void PrintArray(double[]collec)
{
    int count = collec.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collec[position]);
        Console.Write(" ");
        position++;
    }
}
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];
FillArrayInOrder(array);
CubicArray(array);
PrintArray(array);
