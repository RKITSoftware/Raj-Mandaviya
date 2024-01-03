using System;
using System.Data;

namespace DataTable_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable = new DataTable();
            //Add a Column object directly
            dataTable.Columns.Add("userID", typeof(int));

            //Create and Add Column Objects
            DataColumn columnName = new DataColumn("name", typeof(string));
            DataColumn columnAge = new DataColumn("age", typeof(int));

            dataTable.Columns.Add(columnName);
            dataTable.Columns.Add(columnAge);

            // Create a new row and add it to the DataTable
            DataRow row = dataTable.NewRow();
            row["userID"] = 1;
            row["name"] = "Raj";
            row["age"] = 20;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["userID"] = 2;
            row["name"] = "Aum";
            row["age"] = 21;
            dataTable.Rows.Add(row);

            //Iterating through Datatable
            Console.WriteLine("DataTable: ");
            foreach (DataRow rowElement in dataTable.Rows)
            {
                Console.WriteLine($"Name: {rowElement["name"]}; Age: {rowElement["age"]}");
            }

            //Filter through datatable
            DataRow[] results = dataTable.Select("userID = 1");

            Console.WriteLine("Rows with userID = 1");
            foreach (DataRow rowElement in results)
            {
                Console.WriteLine(rowElement["name"]);
            }
        }

    }
}
