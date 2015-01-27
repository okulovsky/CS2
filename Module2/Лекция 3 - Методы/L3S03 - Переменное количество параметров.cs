using System;

public class L3S03
{
    static void Print(ConsoleColor foreColor, params string[] lines)
    {
        Console.ForegroundColor = foreColor;
        foreach (var e in lines)
            Console.WriteLine(e);
        SuperConsole.Line();
    }

    public static void MainX()
    {
        Print(ConsoleColor.Red);
        Print(ConsoleColor.Blue, "a", "b", "c");
        var array = new string[] { "x", "y", "z" };
        Print(ConsoleColor.Green, array);
    }
}

//!Метод с переменным количеством аргументов