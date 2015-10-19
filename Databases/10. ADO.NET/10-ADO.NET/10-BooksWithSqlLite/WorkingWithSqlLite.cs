//    * Write methods for listing all books, finding a book by name and adding a book using SQL Lite
namespace BooksWithSqlLite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SQLite;

    public class WorkingWithSqlLite
    {
        static void Main()
        {
            string connectionStr = "Data Source =../../Library;Version = 3;";

            AddBook(connectionStr, "La divina Commedia", "Dante Alighieri", DateTime.Now, 58746941);

            ListAllBooks(connectionStr);

            FindBook(connectionStr);

        }

        // listing all books
        private static void ListAllBooks(string connectionStr)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionStr);
            connection.Open();
            using (connection)
            {
                SQLiteCommand command = new SQLiteCommand("select * from books", connection);
                SQLiteDataReader reader = command.ExecuteReader();

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
            SQLiteConnection connection = new SQLiteConnection(connectionStr);
            connection.Open();
            using (connection)
            {
                SQLiteCommand command = new SQLiteCommand(
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

            SQLiteConnection connection = new SQLiteConnection(connectionStr);
            connection.Open();
            using (connection)
            {
                SQLiteCommand command = new SQLiteCommand(
                     String.Format("SELECT * FROM books WHERE title LIKE '%{0}%'", escapedTitle), connection);

                SQLiteDataReader reader = command.ExecuteReader();

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
