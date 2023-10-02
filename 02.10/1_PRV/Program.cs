using System;

public class Program
{
    public static void Main()
    {
        var a = int.Parse(Console.ReadLine());

        if (a == 0)
            Console.WriteLine("Зеленый");
        // черный \ красный
        if (a >= 1 && a <= 10)
        {
            if (a % 2 == 0)
                Console.WriteLine("черный");
            if (a % 2 != 0)
                Console.WriteLine("красный");

        }
        // красный \ черный
        if (a >= 1 && a <= 18)
        {
            if (a % 2 == 0)
                Console.WriteLine("красный");
            if (a % 2 != 0)
                Console.WriteLine("черный");

        }
        // черный \ красный
        if (a >= 19 && a <= 28)
        {
            if (a % 2 == 0)
                Console.WriteLine("черный");
            if (a % 2 != 0)
                Console.WriteLine("красный");

        }
        // красный \ черный
        if (a >= 29 && a <= 36)
        {
            if (a % 2 == 0)
                Console.WriteLine("красный");
            if (a % 2 != 0)
                Console.WriteLine("черный");

        }

        if (a > 36 || a < 0)
            Console.WriteLine("Пользователь ввел число, которое лежит вне диапазона от 0 до 36");

        /* Первия версия, её Я переделал для удобного чтения ^
                if ( a == 0 )
                    Console.WriteLine("Зеленый");
                else if ( a <= 10 && a >= 1 && a%2!=0)
                    Console.WriteLine("красный");
                else if ( a <= 10 && a >= 1 && a%2==0)
                    Console.WriteLine("черный");
                else if ( a <= 18 && a >= 11 && a%2!=0)
                    Console.WriteLine("Черный");
                else if (  a <= 18 && a >= 11 && a%2==0 )
                    Console.WriteLine("красный");
                else if (  a <= 28 && a >= 19 && a%2!=0)
                    Console.WriteLine("красный");
                else if (  a <= 28 && a >= 19 && a%2==0)
                    Console.WriteLine("Черный");
                else if (  a <= 28 && a >= 19 && a%2!=0)
                    Console.WriteLine("Черный");
                else if (  a <= 36 && a >= 29 && a%2==0)
                    Console.WriteLine("красный");
                if (a > 36 || a < 0)
                    Console.WriteLine("пользователь вводит число, которое лежит вне диапазона от 0 до 36");
        */
    }

}