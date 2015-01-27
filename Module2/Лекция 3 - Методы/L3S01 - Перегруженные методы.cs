using System;

public class L3S01
{
    public static void Print(string text, ConsoleColor foreColor, ConsoleColor backColor)
    {
        Console.ForegroundColor = foreColor;
        Console.BackgroundColor = backColor;
        Console.WriteLine(text);
    }

    public static void Print(string text, ConsoleColor foreColor)
    {
        Print(text, foreColor, ConsoleColor.Black);
    }

    public static void Print(string text)
    {
        Print(text, ConsoleColor.Gray, ConsoleColor.Black);
    }

    public static void MainX()
    {
        Print("some text here", ConsoleColor.Yellow, ConsoleColor.Blue);
        Print("some text here", ConsoleColor.Yellow);
        Print("some text here");
    }


}

//!Перегруженные методы