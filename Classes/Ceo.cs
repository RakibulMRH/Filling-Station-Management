using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    class Ceo : Employee
    {

        public Ceo()
        {

        }

        private string role;

        public String Role
        {
            get { return role; }
            set { role = value; }
        }



        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from EMPLOYEEDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);

            return d1;
        }

        //Inserting data into database table
        public bool Insert(Employee l)
        {
            String empId, eName, salary, phoneNum, address, gender, role;
            empId = l.EmpId;
            eName = l.Ename;
            salary = l.Salary;
            phoneNum = l.PhoneNumber;
            address = l.Address;
            gender = l.Gender;
            role = l.Role;

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database Connection

            SqlConnection c1 = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {

                //Step 2: Writing SQL query

                string query = "INSERT INTO EmployeeDB (empId, eName, salary, phoneNum, address, gender, role)VALUES(@EMPID,@ENAME,@SALARY,@PHONENUM,@ADDRESS,@GENDER,@ROLE)";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);
                c1.Open();
                cmd.Parameters.AddWithValue("@EMPID", empId);
                cmd.Parameters.AddWithValue("@ENAME", eName);
                cmd.Parameters.AddWithValue("@SALARY", salary);
                cmd.Parameters.AddWithValue("@PHONENUM", phoneNum);
                cmd.Parameters.AddWithValue("@ADDRESS", address);
                cmd.Parameters.AddWithValue("@GENDER", gender);
                cmd.Parameters.AddWithValue("@ROLE", role);
                MessageBox.Show(empId);




                if (c1.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                        MessageBox.Show("Succesfully Saved!");
                    }
                    else
                        MessageBox.Show("ERROR!");

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
        public bool Update(Employee l)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {
                //Step 2: Writing SQL query

                string query = "Update EmployeeDB set EMPID=@empId,ENAME=@name,ESALARY=@salary,PHONENUM=@phoneNum,ADDRESS=@address,GENDER=@gender,ROLE=@role";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

                cmd.Parameters.AddWithValue("@EMPID", l.EmpId);
                cmd.Parameters.AddWithValue("@ENAME", l.Ename);
                cmd.Parameters.AddWithValue("@ESALARY", l.Salary);
                cmd.Parameters.AddWithValue("@PHONENUM", l.PhoneNumber);
                cmd.Parameters.AddWithValue("@ADDRESS", l.Address);
                cmd.Parameters.AddWithValue("@GENDER", l.Gender);
                cmd.Parameters.AddWithValue("@ROLE", l.Role);


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
                MessageBox.Show("Something went Wrong!");
            }
            finally
            {
                c1.Close();
            }
            MessageBox.Show("Employee Added!");
            return isSuccess;
        }

        //Deleting data into database table
        public bool Delete(Ceo l)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {


                //Step 2: Writing SQL query

                string query = "Delete from Employee where UserName=@username";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

                cmd.Parameters.AddWithValue("@EMPID", l.EmpId);


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

        //Show All Emp data from database table
        public bool Show(Ceo l)
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
            catch (Exception e)
            {

            }
            finally
            {
                c1.Close();
            }
            return isSuccess;
        }

        ///////////////////////////////////////
        //Deleting Transaction Data from database table
        public bool DeleteTrx(Manager l)
        {
            //creating a default return type and setting its value to false

            bool isSuccess = false;
            Ceo ceo = new Ceo();

            //Step 1: Database Connection
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {
                //Step 2: Writing SQL query

                string query = "Delete from TransactionDB where TRANNO=@tranNo";
                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, c1);

                Customer c = new Customer();

                cmd.Parameters.AddWithValue("@TRANNO", c.TranNo);


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

        //Show All Emp data from database table
        public bool ShowAllEmp(Manager l)
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
