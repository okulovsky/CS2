using System;
class L3S08
{
    static void UpdateString(ref string str)
    {
        str += "a";
    }

    public static void MainX()
    {
        var str = "bc";
        Console.WriteLine(str);

        UpdateString(ref str);
        Console.WriteLine(str);
    }

}

//!И то же самое со строкой