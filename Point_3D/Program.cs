//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double leg1 = x2 - x1;
    double leg2 = y2 - y1;
    double leg3 = z2 - z1;
    double distance = Math.Sqrt (Math.Pow (leg1,2) + Math.Pow (leg2,2) + Math.Pow (leg3,2));
    Console.WriteLine(distance);
}

Console.WriteLine ("Введите, пожалуйста, координаты точки А последовательно по осям x,y,z");
double x1 = int.Parse(Console.ReadLine());
double y1 = int.Parse(Console.ReadLine());
double z1 = int.Parse(Console.ReadLine());


Console.WriteLine ("Введите, пожалуйста, координаты точки B последовательно по осям x,y,z");
double x2 = int.Parse(Console.ReadLine());
double y2 = int.Parse(Console.ReadLine());
double z2 = int.Parse(Console.ReadLine());

Distance3D (x1, y1, z1, x2, y2, z2);
