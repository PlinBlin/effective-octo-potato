using System;

public class Program
{
    public static void Main()
    {
        int a1 = int.Parse(Console.ReadLine());
        int b1 = int.Parse(Console.ReadLine());
        int a2 = int.Parse(Console.ReadLine());
        int b2 = int.Parse(Console.ReadLine());

        int sStart = Math.Max(a1, a2);
        int eEnd = Math.Min(b1, b2);

        if (sStart <= eEnd)
            Console.WriteLine(sStart + " " + eEnd);
        else
            Console.WriteLine("пустое множество");
    }
}