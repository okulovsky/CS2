using System;
namespace L3S04
{
    public class Program
    {
        public static void GetNameAndAge(out string Name, out int Age)
        {
            Name = Console.ReadLine();
            Age = int.Parse(Console.ReadLine());
        }

        public static void MainX()
        {
            string Name;
            int Age;
            GetNameAndAge(out Name, out Age);
            Console.WriteLine("{0} {1}", Name, Age);
        }
    }
}

//!Как заставить метод возвращать два значения? Out параметры