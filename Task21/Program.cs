//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double sum = 0;
for(int i = 1; i < 4; i++)
    {
    Console.WriteLine("Введите координату x1 (" + i + ")");
    double x1 = Convert.ToDouble( Console.ReadLine());
    Console.WriteLine("Введите координату x2 (" + i + ")");
    double x2 = Convert.ToDouble( Console.ReadLine());
    sum = sum + Math.Pow(x2 - x1, 2);
    
    Console.WriteLine("x1:" + x1);
    Console.WriteLine("x2:" + x2);
    Console.WriteLine("sum:" + sum);
    Console.WriteLine();
    }
double dist = Math.Sqrt(sum);
Console.WriteLine("Растояние между точками равно: " + dist + " у.е.");
