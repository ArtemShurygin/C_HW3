//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в N-мерном пространстве.
//Сначала задается N с клавиатуры, потом задаются координаты точек.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double sum = 0;

Console.WriteLine("Введите размерность N N-мерного пространства:");
int N = Convert.ToInt32( Console.ReadLine());
if (N >= 1)
    {
    for(int i = 1; i < N + 1; i++)
        {
        Console.WriteLine("Введите координату x1 (" + i + ")");
        double x1 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine("Введите координату x2 (" + i + ")");
        double x2 = Convert.ToDouble( Console.ReadLine());
        sum = sum + Math.Pow(x2 - x1, 2);
        /*
        Console.WriteLine("x1:" + x1);
        Console.WriteLine("x2:" + x2);
        Console.WriteLine("sum:" + sum);
        */
        Console.WriteLine();
        }
    double dist = Math.Sqrt(sum);
    Console.WriteLine("Расcтояние между точками равно: " + dist + " у.е.");
    }
else
    Console.WriteLine("Размерность N N-мерного пространства должна быть больше или ровна 1");
    
