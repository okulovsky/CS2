using System;

class L3S07
{
    public static void WrongUpdateInt(int argument)
    {
        argument++;        
    }

    public static void UpdateInt(ref int argument)
    {
        argument++;
    }

    public static void MainX()
    {
        int arg = 1;
        Console.WriteLine(arg);

        WrongUpdateInt(arg); //это бессмысленно, изменения не произойдет
        Console.WriteLine(arg);

        UpdateInt(ref arg);
        Console.WriteLine(arg);
    }
}

//!Передача структуры в метод по ссылке