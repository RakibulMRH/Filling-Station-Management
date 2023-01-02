using System;
using System.Data;
using System.Data.SqlClient;

namespace FillingStationManagementSystem.Classes
{
    class Login
    {
        private string username;
        private string password;

        public String UserName
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from Log_In";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);

            return d1;
        }

        //Inserting data into database table
        public bool Insert(Login l)
        {

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {

                //Step 2: Writing SQL query

                string query = "Insert into Log_In (UserName,Password)values(@UserName,@Password)";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

                cmd.Parameters.AddWithValue("@UserName", l.UserName);
                cmd.Parameters.AddWithValue("@Password", l.Password);


                c1.Open();

                if (c1.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c1.Close();
            }
            return isSuccess;
        }

        //Updating data into database table
        public bool Update(Login l)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {


                //Step 2: Writing SQL query

                string query = "Update Log_In set LogIn=@username, Password=@password";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

                cmd.Parameters.AddWithValue("@UserName", l.UserName);
                cmd.Parameters.AddWithValue("@Password", l.Password);


                c1.Open();

                if (c1.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c1.Close();
            }
            return isSuccess;
        }


        //Deleting data into database table
        public bool Delete(Login l)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {


                //Step 2: Writing SQL query

                string query = "Delete from Log_In where UserName=@username";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

                cmd.Parameters.AddWithValue("@username", l.UserName);

                c1.Open();

                if (c1.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c1.Close();
            }
            return isSuccess;
        }

    }
}
