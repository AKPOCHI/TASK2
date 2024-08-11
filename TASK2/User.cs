
using System.Data;

namespace TASK2
{
    internal class User
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string EmailAddress { get; set; }
            public int DateOfBirth { get; set; }

        public  DataTable ShowTable() 
        {
            DataTable table = new DataTable();

            //add colums to the table
            table.Columns.Add("FULLNAME", typeof(string));
            table.Columns.Add("ACCOUNT NUMBER", typeof(string));
            table.Columns.Add("ACCOUNT TYPE", typeof(string));
            table.Columns.Add("AMOUNT BALANCE", typeof(int));
            table.Columns.Add("NOTE", typeof(string));

            //add rows to the table
           table.Rows.Add("JOHN DOE", "0987654321","SAVINGS",10000 , "GIFT");
            table.Rows.Add("AKPOCHI PAUL", "0227133074", "SAVINGS", 20000, "INVESTMENT");

            return table;
        }

        public void PrintTable(DataTable table)
        {
            // Print column headers
            foreach (DataColumn column in table.Columns)
            {
                Console.Write(column.ColumnName + "\t");
            }
            Console.WriteLine();

            // Print rows
            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
        }



    }
}
