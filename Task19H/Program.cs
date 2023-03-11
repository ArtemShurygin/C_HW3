//Задача 19 - HARD необязательная
//Напишите программу, которая принимает на вход целое число любой разрядности и проверяет,
//является ли оно палиндромом. Через строку нельзя решать само собой.

//14212 -> нет
//12821 -> да
//1234321 -> да

Console.WriteLine("Введите число:");
int in_num = Convert.ToInt32( Console.ReadLine());
Palindrom(in_num);

void Palindrom(int in_num)
    {
    int k = 0;
    int l = 0;
    int num = 1;

    if (in_num >= 0)
    {
        while (in_num >= num)
            {
                l = l + 1;
                num = num * 10;
            }
        int l2 = l/2;
        double ni = Math.Pow(10,l - 1);
        int n = (int)ni;
        /*
        Console.WriteLine(l);
        Console.WriteLine(l2);
        Console.WriteLine(n);
        Console.WriteLine();
        */
        for (int i = 0; i < l2; i++)
            {
            int res = in_num / n;
            int l_num = (res % 10);
            int r_num = (in_num % 10);
            if (l_num > r_num | l_num < r_num)
                k = k + 1;
            /*
            Console.WriteLine(in_num);
            Console.WriteLine(l_num);
            Console.WriteLine(r_num);
            Console.WriteLine(k);
            Console.WriteLine();
            */
            n = n / 100;
            in_num = in_num /10;
            }
            
        Console.WriteLine("Введенное число является палиндромом?");
        if (k == 0)
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
    }
    else
        Console.WriteLine("Не является палиндромом, введите положительное число");
    }