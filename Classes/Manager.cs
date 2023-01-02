using System;
using System.Data;
using System.Data.SqlClient;

namespace FillingStationManagementSystem.Classes
{
    class Manager : Employee
    {
        public Manager()
        {

        }

        string role;
        public String Role
        {
            get { return role; }
            set { role = value; }
        }

        //Show All Emp data from database table
        public bool ShowEmp(Manager l)
        {

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {

                //Step 2: Writing SQL query

                string query = "Select * FROM EmployeeDB";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

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
            catch (Exception)
            {

            }
            finally
            {
                c1.Close();
            }
            return isSuccess;
        }

        ////////////////////////////////////////////////////////////
        //Show All Stock data from database table
        public bool ShowStock(Manager l)
        {

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {

                //Step 2: Writing SQL query

                string query = "Select * FROM StockDB";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

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

        /////////////////////////////////////////////////////////////////////////
        //Show All Transactions data from database table
        public bool Show(Manager l)
        {

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {

                //Step 2: Writing SQL query

                string query = "Select * FROM TransactionDB";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

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
