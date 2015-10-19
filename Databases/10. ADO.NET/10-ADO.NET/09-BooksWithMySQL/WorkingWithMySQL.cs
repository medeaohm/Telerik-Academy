//Download and install `MySQL` database, `MySQL Connector/Net` (.NET Data Provider for MySQL) + `MySQL Workbench` GUI administration tool.
//    * Create a MySQL database to store `Books` (title, author, publish date and ISBN).
//    * Write methods for listing all books, finding a book by name and adding a book.
namespace BooksWithMySQL
{
    using MySql.Data.MySqlClient;
    using System;

    public class WorkingWithMySQL
    {
        static void Main()
        {
            // Before running the application please execute the CreateLibrary.sql script with MySQL workbrench

            string password = ReadPassword();

            string connectionStr = "Server=localhost;Database=library;Uid=root;Pwd=" + password + ";";

            AddBook(connectionStr, "La divina Commedia", "Dante Alighieri", DateTime.Now, 58746941);

            ListAllBooks(connectionStr);

            FindBook(connectionStr);
            
        }

        private static string ReadPassword()
        {
            Console.Write("Enter pass: ");
            string pass = Console.ReadLine();
            return pass;
        }

        // listing all books
        private static void ListAllBooks(string connectionStr)
        {
            MySqlConnection connection = new MySqlConnection(connectionStr);
            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand("select * from books", connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + " - ");
                    }
                    Console.WriteLine();
                }
            }
        }

        // adding a book
        private static void AddBook(string connectionStr, string title, string author, DateTime publishDate, int isbn)
        {
            MySqlConnection connection = new MySqlConnection(connectionStr);
            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand(
                     @"INSERT INTO books (title, author, publishDate, isbn) 
                    VALUES (@title, @author, @publishDate, @isbn)",
                     connection);

                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@publishDate", publishDate);
                command.Parameters.AddWithValue("@isbn", isbn);

                command.ExecuteNonQuery();
            }
        }

        // finding a book by name
        private static void FindBook(string connectionStr)
        {
            Console.WriteLine();
            Console.Write("Please insert the title you want to search: ");
            string title = Console.ReadLine();
            string escapedTitle = EscapeInputString(title);

            MySqlConnection connection = new MySqlConnection(connectionStr);
            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand(
                     String.Format("SELECT * FROM books WHERE title LIKE '%{0}%'", escapedTitle), connection);

                MySqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("Books Finded:");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + " - ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static string EscapeInputString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\'')
                {
                    input = input.Substring(0, i) + "'" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '_')
                {
                    input = input.Substring(0, i) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '%')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '&')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }
            }
            return input;
        }
    }
}
