using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace Module8
{
    class L3S03
    {
        public static void Main()
        {

            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\..\..\Database.sdf");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "Delete from Employee;";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into Employee values(1,'John','Smith',20);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into Employee values(2,'George','Williams',25);";
            cmd.ExecuteNonQuery();
            connection.Close();

            var db = new DatabaseEntities();
            foreach (var e in db.Employee)
                Console.WriteLine("{0,-10}{1,-10}", e.FirstName, e.LastName);
            Console.WriteLine();

            foreach(var e in db.Employee.Where(z=>z.Age>20))
                Console.WriteLine("{0,-10}{1,-10}", e.FirstName, e.LastName);
            Console.WriteLine();

            db.Employee.DeleteObject(db.Employee.Where(z => z.FirstName == "John").First());
            db.Employee.Where(z => z.FirstName == "George").First().FirstName = "Vance";

            db.Employee.AddObject(new Employee
            {
                id = 3,
                FirstName = "Alex",
                LastName = "Tailor",
                Age = 30
            });

            db.SaveChanges();
        }
    }
}