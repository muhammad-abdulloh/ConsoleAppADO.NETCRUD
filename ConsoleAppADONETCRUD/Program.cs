using System;
using System.Data.SqlClient;

namespace ConsoleAppADONETCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoCRUD;Integrated Security=True";

            try
            {
                sqlConnection = new SqlConnection(CONNECTION_STRING);
                sqlConnection.Open();
                Console.WriteLine("Succsessfully connected database :)");
                /** Create
                // Create => CRUD

                Console.WriteLine("Entering UserName: ");
                string username = Console.ReadLine();

                Console.WriteLine("Entering Age: ");
                int age = int.Parse(Console.ReadLine());
                string insertQuery = $"INSERT INTO Details (UserName, Age) VALUES ('{username}', {age});";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Succsessfully create date! ");*/

                /** Read
                string displayQuery = "Select * from Details;";
                SqlCommand cmd = new SqlCommand(displayQuery, sqlConnection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("Id: {0}", dataReader.GetValue(0).ToString());
                    Console.WriteLine("UserName: {0}", dataReader.GetValue(1).ToString());
                    Console.WriteLine("Age: {0}", dataReader.GetValue(2).ToString());
                }
                dataReader.Close();
                sqlConnection.Close();
                */


                /** Update
                int id;
                int age;
                Console.WriteLine("Entering ID: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Entering Age: ");
                age = int.Parse(Console.ReadLine());

                string updateQuery = $"Update Details Set Age = {age} where Id = {id};";
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("Succsessfully update date! ");
                sqlConnection.Close();
                */

                // Delete
                int delId;
                Console.WriteLine("Deleted Entering in Id: ");
                delId = int.Parse(Console.ReadLine());
                string deleteQuery = $"Delete from Details where Id = {delId};";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("Succsessfully deleted date! ");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
