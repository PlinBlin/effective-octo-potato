using System;

public class Program
{
    public static void Main()
    {
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        string result;

        if ((a == "красный" && b == "синий") || (a == "синий" && b == "красный"))
            result = "Фиолетовый";
        else if ((a == "красный" && b == "желтый") || (a == "желтый" && b == "красный"))
            result = "Оранжевый";
        else if ((a == "синий" && b == "желтый") || (a == "желтый" && b == "синий"))
            result = "Зеленый";
        else
            result = "ошибка цвета";
        
        Console.WriteLine(result);
    }
}