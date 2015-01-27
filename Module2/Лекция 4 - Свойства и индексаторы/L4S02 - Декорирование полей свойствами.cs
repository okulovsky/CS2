using System;
namespace L4S02
{
    public class Employee
    {
        double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                salary = value;
            }
        }
    }

    class Program
    {
        public static void MainX()
        {
            var emp = new Employee();
            emp.Salary = 10000;
            emp.Salary*=2;
            Console.WriteLine(emp.Salary);
        }
    }
}

//!Свойства: удобно и элегантно. Проверка целостности убрана в сеттер.
