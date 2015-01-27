using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

class L3S02
{
    public static void MainX()
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

        
        var adapter = new SqlCeDataAdapter("Select * from Employee", connection);
        new SqlCeCommandBuilder(adapter);
        var set = new DataSet();
        adapter.Fill(set,"Employee");
        connection.Close();

        var table = set.Tables[0];
        for (int i = 0; i < table.Rows.Count; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write("{0,-10}", table.Rows[i][j]);
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");

        table.Rows[0]["FirstName"] = "Jim";
        var row = table.NewRow();
        row["Id"] = 3;
        row["FirstName"] = "James";
        row["LastName"] = "Tailor";
        row["Age"] = 30;
        table.Rows.Add(row);
        table.Rows.Remove(table.Rows[1]);

        connection.Open();
        adapter.Update(table);
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