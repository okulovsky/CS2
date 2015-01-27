using System;
namespace L4S04
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
        }

        public void SetSalary(double basicSalary, double premie)
        {
            salary = basicSalary + premie;
            if (salary < 0) throw new ArgumentException();
        }

    }

}

//!Сеттер может отсутствовать. Свойство только для чтение, изменяемое сторонним методом