using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

class L3S01
{
    public static void MainX()
    {
        var  connection = new SqlCeConnection(@"Data Source=|DataDirectory|\..\..\Database.sdf");
        connection.Open();
        
        var cmd = connection.CreateCommand();
        cmd.CommandText = "Delete from Employee;";
        cmd.ExecuteNonQuery();
        cmd.CommandText = "Insert into Employee values(1,'John','Smith',20);";
        cmd.ExecuteNonQuery();
        cmd.CommandText = "Insert into Employee values(2,'George','Williams',25);";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "Select * from Employee";
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            for (int i = 0; i < 4; i++)
                Console.Write("{0,-10}", reader[i]);
            Console.WriteLine();
        }
        connection.Close();
    }
}