using System;
namespace L4S05
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

            private set
            {
                if (value < 0) throw new ArgumentException();
                salary = value;
            }
        }

        public void SetSalary(double basicSalary, double premie)
        {
            salary = basicSalary + premie;
           
        }
        
    }
}

//!Более элегантно: проверка целостности в сеттере, присвоение - в методе.