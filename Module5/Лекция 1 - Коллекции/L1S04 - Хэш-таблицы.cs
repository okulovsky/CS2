using System.Collections.Generic;
using System;
class L1S04
{
    public static void MainX()
    {
        var salaries = new Dictionary<string, double>();
        salaries["Smith"] = 10000;
        salaries["Jones"] = 20000;

        foreach (var e in salaries)
            Console.WriteLine("{0,10}  {1}", e.Key, e.Value);
        SuperConsole.Line();

        Console.WriteLine(salaries["Jones"]);
    }
}

//!Генерик-словарь