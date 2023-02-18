// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Palindrome (int value)
{
    int e = value % 10;
    int d = (value % 100)/ 10;
    int a = value / 10000;
    int b = (value / 1000) % 10;

    if ((a == e) && (b == d))
    {
    Console.WriteLine("Да, это палиндром");
    }
    else
    {
    Console.WriteLine("Нет, это не палиндром");
    }
}

Console.WriteLine("Введите, пожалуйста, пятизначное число, а я подскажу, палиндром ли это");
int n = int.Parse(Console.ReadLine());
Palindrome (n);