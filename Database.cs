using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies2018
{
    public class Database
    {
        //Create Connection and Command,and an Adapter.
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();


        public int CustID { get; set; }
        public int MovieID { get; set; }

        public Database()
        {

            //change the connection string to run from your own db
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = VBMoviesFullData; Integrated Security = True";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;

        }

        //Takes all data from Customers
        public DataTable FillDgvCustomers()
        {
            DataTable dt = new DataTable();

            using (da = new SqlDataAdapter("select * from Customer", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        //Takes all data from Movies
        public DataTable FillDgvMovies()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Movies", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        //Takes all data from Rented Movies
        public DataTable FillDgvRented()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from RentedMovies", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public string AddOrUpdateCustomer(string ID, string FirstName, string LastName, string Address, string Phone, string DateJoined, string AddOrUpdate)
        {
            try
            {
                //Add gets passed through the parameter 
                if (AddOrUpdate == "Add")
                {
                    //Create a Command object  //Create a Query. Create and open a connection to SQL Server 
                    string query = "INSERT INTO Customer (FirstName, LastName, Address, Phone, Date) VALUES (@FirstName, @LastName, @Address, @Phone, @DateJoined)";

                    var myCommand = new SqlCommand(query, Connection);
                    //create params
                    myCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    myCommand.Parameters.AddWithValue("@LastName", LastName);
                    myCommand.Parameters.AddWithValue("@Address", Address);
                    myCommand.Parameters.AddWithValue("@Phone", Phone);
                    myCommand.Parameters.AddWithValue("@DateJoined", DateJoined);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //Update gets passed through the parameter 
                else if (AddOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Customer set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone, Date = @Date where CustID = @CustID ", Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    myCommand.Parameters.AddWithValue("@LastName", LastName);
                    myCommand.Parameters.AddWithValue("@Address", Address);
                    myCommand.Parameters.AddWithValue("@Phone", Phone);
                    myCommand.Parameters.AddWithValue("@Date", DateJoined);
                    myCommand.Parameters.AddWithValue("@CustID", ID);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " is Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + e;
            }
        }

        public void DeleteCustomer(string ID)
        {
            var myCommand = new SqlCommand("DELETE FROM Customer where CustID = @ID", Connection);
            myCommand.Parameters.AddWithValue("ID", ID);
            Connection.Open();
            myCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public string AddOrUpdateMovie(string ID, string Title, string Genre, string Year, string Rating, string Plot, string Copies, string Rental_Cost, string Date, string AddOrUpdate)
        {
            try
            {
                //Add gets passed through the parameter 
                if (AddOrUpdate == "Add")
                {
                    //Create a Command object  //Create a Query. Create and open a connection to SQL Server 
                    string query = "INSERT INTO Movies (Title, Genre, Year, Rating, Plot, Copies, Rental_Cost, Date) " + "VALUES (@Title, @Genre, @Year, @Rating, @Plot, @Copies, @Rental_Cost, @DateOfUpload)";

                    var myCommand = new SqlCommand(query, Connection);
                    //create params
                    myCommand.Parameters.AddWithValue("@Title", Title);
                    myCommand.Parameters.AddWithValue("@Genre", Genre);
                    myCommand.Parameters.AddWithValue("@Year", Year);
                    myCommand.Parameters.AddWithValue("@Rating", Rating);
                    myCommand.Parameters.AddWithValue("@Plot", Plot);
                    myCommand.Parameters.AddWithValue("@Copies", Copies);
                    myCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("@DateOfUpload", Date);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //Update gets passed through the parameter 
                else if (AddOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Movies set Title = @Title, Genre = @Genre, Year = @Year, Rating = @Rating, Plot = @Plot, Copies = @Copies, Rental_Cost = @Rental_Cost, DateOfUpload = @DateOfUpload,  where MovieID = @MovieID ", Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Copies", Copies);
                    myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("DateOfUpload", Date);
                    myCommand.Parameters.AddWithValue("MovieID", ID);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return AddOrUpdate + " is Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();


                return " has Failed with " + e.ToString();
            }
        }

        public void DeleteMovie(string ID)
        {
            var myCommand = new SqlCommand("DELETE FROM Movies where MovieID = @ID", Connection);
            myCommand.Parameters.AddWithValue("ID", ID);
            Connection.Open();
            myCommand.ExecuteNonQuery();
            Connection.Close();
        }

    }
}
