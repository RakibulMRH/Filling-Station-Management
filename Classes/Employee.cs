using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    class Employee
    {
        private String empId;
        private String name;
        private String salary;
        private String phoneNum;
        private String address;
        private String gender;
        private String role;
        private String username;
        private String frontusername;
        private String lastusername = "-22";

        public String generateNewEmpUserName()
        {
            int baseID = 0;
            int rows = 0;
            if (role == "Manager")
            {
                baseID = 10001;
                frontusername = "MG-";
            }
            if (role == "Cashier")
            {
                baseID = 20001;
                frontusername = "AC-";
            }
            if (role == "Lineman")
            {
                baseID = 30001;
                frontusername = "LM-";
            }
            SqlConnection c1 = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {
                String querry = "SELECT * FROM EmployeeDB";
                SqlDataAdapter sda = new SqlDataAdapter(querry, c1);
                DataTable d1 = new DataTable();
                sda.Fill(d1);
                rows = d1.Rows.Count;
                baseID += rows;
                username = frontusername + baseID.ToString() + lastusername;
                MessageBox.Show(username);
            }
            finally
            {
                c1.Close();
            }

            return username;
        }



        public String EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public String Ename
        {
            get { return name; }
            set { name = value; }
        }
        public String Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public String PhoneNumber
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String Role
        {
            get { return role; }
            set { role = value; }
        }
        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }





        void showDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Salary: " + salary);
            Console.WriteLine("Employee Address: " + address);
            Console.WriteLine("Employee Phone Number: " + phoneNum);
            Console.WriteLine("Employee Gender: " + gender);
        }

    }
}
