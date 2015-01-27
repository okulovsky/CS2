using System;

class L3S06
{
    static Tuple<string, int> GetNameAndAge()
    {
        var name= Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var res = new Tuple<string, int>(name, age); //или Tuple.Create(name,age)
        return res;
    }

    public static void MainX()
    {
        var res = GetNameAndAge();
        Console.WriteLine("{0} {1}", res.Item1, res.Item2);
    }
}

//!Неряшливый генерик-способ (генерики у нас будут чуть позже)