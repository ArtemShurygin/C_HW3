//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом. Через строку решать нельзя.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32( Console.ReadLine());

Palindrom5(num);

void Palindrom5(int num)
    {
    int n = 10000;
    int r_num = 0;
    int l_num = 0;
    int res = 0;
    int k = 0;
    if (num < 100000 & num > 9999)
        {
        for (int i = 1; i < 3; i++)
            {
            res = num / n;
            l_num = (res % 10);
            r_num = (num % 10);
            if (l_num > r_num | l_num < r_num)
                k = k + 1;
            /*
            Console.WriteLine(num);
            Console.WriteLine(l_num);
            Console.WriteLine(r_num);
            Console.WriteLine(k);
            Console.WriteLine();
            */
            n = n / 100;
            num = num /10;
            }
        Console.WriteLine("Введенное число является палиндромом?");
        if (k == 0)
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
        }
    else 
        Console.WriteLine("Введенное число должно быть пятизначным");
    }