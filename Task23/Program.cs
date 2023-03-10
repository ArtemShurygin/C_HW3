//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int N = Convert.ToInt32( Console.ReadLine());
if (N>0)
    {
    for(int i = 1; i < N + 1; i++)
        {
        double cubeN = Math.Pow(i,3);
        Console.Write(cubeN + "  ");
        }
    }
else
Console.WriteLine("Введенное число должно быть целым, положительным и больше 1");