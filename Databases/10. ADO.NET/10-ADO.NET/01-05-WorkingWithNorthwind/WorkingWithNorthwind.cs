namespace WorkingWithNorthwind
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;

    public class WorkingWithNorthwind
    {
        private const string ConnectionString = "Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true";

        public static void Main()
        {
            // 1.Write a program that retrieves from the `Northwind` sample database in MS SQL Server the number of rows in the `Categories` table.
            CategoriesCount(ConnectionString);

            // 2. Write a program that retrieves the name and description of all categories in the `Northwind` DB.
            CategoriesAndDescription(ConnectionString);

            // 3. Write a program that retrieves from the `Northwind` database all product categories and the names of the products in each category. *Can you do this with a single SQL query (with table join)?
            CategoriesAndProducts(ConnectionString);

            // 4. Write a method that adds a new product in the products table in the `Northwind` database. Use a parameterized SQL command.
            AddProduct(ConnectionString);

            //5. Write a program that retrieves the images for all categories in the `Northwind` database and stores them as JPG files in the file system.
            ExtractImagesFromDBAndSaveToFile(ConnectionString);

            //8. Write a program that reads a string from the console and finds all products that contain this string. *Ensure you handle correctly characters like `'`, `%`, `"`, `\` and `_`.
            SearchProducts(ConnectionString);
        }

        private static void SearchProducts(string connection)
        {
            SqlConnection dbCon = new SqlConnection(connection);
            dbCon.Open();
            Console.Write("Enter the pattern you want to search: ");
            string pattern = Console.ReadLine(); 
            SqlCommand command = new SqlCommand(
                    @"SELECT ProductName FROM Products", dbCon);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string product = (string)reader["ProductName"];
                    if (product.ToLower().Contains(pattern.ToLower()))
                    {
                        Console.WriteLine("{0}", product);
                    }
                }
            }
            Console.WriteLine();
        }

        private static void ExtractImagesFromDBAndSaveToFile(string connection)
        {
            SqlConnection dbCon = new SqlConnection(connection);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories", dbCon);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    var index = 1;
                    while (reader.Read())
                    {
                        var picture = (byte[])reader["Picture"];
                        StorePicturesAsJpegFiles("Picture" + index, picture, ".jpg");
                        index++;
                    }
                }
            }
            Console.WriteLine("Images stored! -> check the folder \\bin\\Debug");
            Console.WriteLine();
        }

        private static void StorePicturesAsJpegFiles(string fileName, byte[] imgBinaryData, string fileExtension)
        {
            const int oleMetaPictStartPosition = 78;

            var memoryStream = new MemoryStream(imgBinaryData, oleMetaPictStartPosition,
                    imgBinaryData.Length - oleMetaPictStartPosition);
            using (memoryStream)
            {
                using (var image = Image.FromStream(memoryStream, true, true))
                {
                    image.Save(fileName + fileExtension);
                }
            }
        }

        private static void AddProduct(string connection)
        {
            SqlConnection dbCon = new SqlConnection(connection);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                    @"INSERT INTO Products 
                    (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
                    VALUES             (@name,@supplierId,@categoryId,@quantityPerUnit,@unitPrice,@unitInStock,@unitsOnOrder,@reordedLevel,@discontinued)", dbCon);

                command.Parameters.AddWithValue("@name", "Salad");
                command.Parameters.AddWithValue("@supplierId", 2);
                command.Parameters.AddWithValue("@categoryId", 5);
                command.Parameters.AddWithValue("@quantityPerUnit", "5 bags");
                command.Parameters.AddWithValue("@unitPrice", 50.00);
                command.Parameters.AddWithValue("@unitInStock", 10);
                command.Parameters.AddWithValue("@unitsOnOrder", 5);
                command.Parameters.AddWithValue("@reorderLevel", 25);
                command.Parameters.AddWithValue("@discontinued", 1);
                Console.WriteLine("The record has been added!");
            }
            Console.WriteLine();
        }

        private static void CategoriesAndProducts(string connection)
        {
            SqlConnection dbCon = new SqlConnection(connection);
            dbCon.Open();
            SqlCommand command = new SqlCommand(
                    @"SELECT c.CategoryName, p.ProductName FROM Categories c JOIN Products p On p.CategoryID = c.CategoryID ORDER BY c.CategoryName", dbCon);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string category = (string)reader["CategoryName"];
                    string product = (string)reader["ProductName"];
                    Console.WriteLine("{0} - {1}", category, product);
                }
            }
            Console.WriteLine();
        }

        private static void CategoriesAndDescription(string connection)
        {
            SqlConnection dbCon = new SqlConnection(connection);
            dbCon.Open();
            SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} - {1}", name, description);
                }
            }
            Console.WriteLine();
        }

        private static void CategoriesCount(string connection)
        {
            SqlConnection dbCon = new SqlConnection(connection);
            dbCon.Open();
            using (dbCon)
            {
                // 1. Write a program that retrieves from the `Northwind` sample database in MS SQL Server the number of rows in the `Categories` table.
                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int categoriesCount = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("Categories count: {0} ", categoriesCount);
                Console.WriteLine();
            }
        }     
    }
}
