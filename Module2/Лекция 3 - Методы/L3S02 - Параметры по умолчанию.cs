using System;

public class L3S02
{
    public static void Print(string text,
        ConsoleColor foreColor = ConsoleColor.Gray,
        ConsoleColor backColor = ConsoleColor.Black)
    {
        Console.ForegroundColor = foreColor;
        Console.BackgroundColor = backColor;
        Console.WriteLine(text);
    }

    public static void MainX()
    {
        Print("some text here", ConsoleColor.Yellow, ConsoleColor.Blue);
        Print("some text here", ConsoleColor.Yellow);
        Print("some text here");
        Print("some text here", backColor: ConsoleColor.Blue);
    }


}

//!Метод с параметрами по умолчанию