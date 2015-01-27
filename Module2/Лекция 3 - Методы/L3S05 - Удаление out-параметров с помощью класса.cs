using System;

class L3S05
{
    class NameAndAge
    {
        public string Name;
        public int Age;
    }

    static NameAndAge GetNameAgeAge()
    {
        var res = new NameAndAge();
        res.Name = Console.ReadLine();
        res.Age = int.Parse(Console.ReadLine());
        return res;
    }

    public static void MainX()
    {
        var res = GetNameAgeAge();
        Console.WriteLine("{0} {1}", res.Name, res.Age);
    }
}

//!Более правильный способ: избегать out-параметров и создать структуру