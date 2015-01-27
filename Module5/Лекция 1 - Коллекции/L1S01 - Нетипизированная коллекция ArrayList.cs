using System.Collections;
using System;
class L1S01
{
    public static void MainX()
    {
        var list = new ArrayList();
        list.Add(10);
        list.Add(30);
        
        for (int i = 0; i < list.Count; i++)
            Console.WriteLine(list[i]);
        SuperConsole.Line();

        foreach (var e in list)
            Console.WriteLine(e);
       
    }
}

//!Нетипизированные коллекции