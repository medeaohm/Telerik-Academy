namespace WorkingWithExcel
{
    using System;
    using System.Data.OleDb;

    public class WorkingWithExcel
    {
        private const string connectionString = @"Provider= Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source = ..\..\Players.xlsx;Extended Properties = ""Excel 12.0 Xml;HDR=YES"";";

        public static void Main()
        {
            // 6.  Create an Excel file with 2 columns: `name` and `score`:
            // Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
            ReadDataFromExcel(connectionString);

            // 7.Implement appending new rows to the Excel file. 
            InsertDataIntoExcel(connectionString, "Milen Tvetkov", 15);
        }

        private static void ReadDataFromExcel(string connection)
        {
            OleDbConnection dbConn = new OleDbConnection(connection);
            dbConn.Open();
            using (dbConn)
            {
                OleDbCommand cmd = new OleDbCommand(@" SELECT * FROM [Foglio1$]", dbConn);
                OleDbDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        double score = (double)reader["Score"];
                        Console.WriteLine("{0} - {1}", name, score);
                    }
                }
                Console.WriteLine();

            }
        }

        private static void InsertDataIntoExcel(string connection, string playerName, double score)
        {
            OleDbConnection dbConn = new OleDbConnection(connection);
            dbConn.Open();
            using (dbConn)
            {
                OleDbCommand cmd = new OleDbCommand(
                    @"INSERT INTO [Foglio1$] (Name, Score) VALUES (@name,@score)", dbConn);
                cmd.Parameters.AddWithValue("@name", playerName);
                cmd.Parameters.AddWithValue("@score", score);

                // Execute command
                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Row inserted successfully.");
                }
                catch (OleDbException exception)
                {
                    Console.WriteLine("SQL Error occured: " + exception);
                }
            }
        }
    }
}
