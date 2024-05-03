using FillingStationManagementSystem.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Forms
{
    public partial class EmpRegister : Form
    {
        String empId, eName, salary, age, phoneNum, address, gender, role, username, password;
        Employee emp = new Employee();
        Ceo c = new Ceo();

        public EmpRegister()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp.Role = comboBox1.SelectedItem.ToString();
            role = emp.Role;

        }

        private void empRegisterNameTB_TextChanged(object sender, EventArgs e)
        {
            emp.Ename = empRegisterNameTB.ToString();
        }

        private void EmpRegister_Load(object sender, EventArgs e)
        {

        }

        private void empRegisterAddressTB_TextChanged(object sender, EventArgs e)
        {
            emp.Address = empRegisterAddressTB.ToString();
        }

        private void empPasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void empRegisterMobileNumTB_TextChanged(object sender, EventArgs e)
        {
            emp.PhoneNumber = empRegisterMobileNumTB.ToString();
        }

        private void empRegisterSalaryTB_TextChanged(object sender, EventArgs e)
        {
            emp.Salary = empRegisterSalaryTB.ToString();
        }

        private void empRegistrationMaleRB_CheckedChanged(object sender, EventArgs e)
        {
            emp.Gender = "Male";
            // gender = empRegistrationMaleRB.Text;
            gender = "male";
        }

        private void empRegistrationFemaleRB_CheckedChanged(object sender, EventArgs e)
        {
            emp.Gender = "Female";
            gender = empRegistrationFemaleRB.Text;
        }

        private void empRegistrationOthersRB_CheckedChanged(object sender, EventArgs e)
        {
            emp.Gender = "Others";
            gender = empRegistrationOthersRB.Text;
        }

        private void EmpRegistrationConfirmBTN_Click(object sender, EventArgs e)
        {
            if (emp.Role != null)
            {
                empId = emp.generateNewEmpUserName();
            }
            else
            {
                MessageBox.Show("Employee Role Must be Declared First!");
            }
            //c.Insert(emp);
            bool isSuccess = false;
            //Login l1 = new Login();

            eName = empRegisterNameTB.Text;
            salary = empRegisterSalaryTB.Text;
            phoneNum = empRegisterSalaryTB.Text;
            address = empRegisterAddressTB.Text;
            password = empPasswordTB.Text;

            try
            {
                string query = "INSERT INTO EmployeeDB (empId,eName,salary,phoneNum,address,gender,role)VALUES(@EMPID,@ENAME,@SALARY,@PHONENUM,@ADDRESS,@GENDER,@ROLE)";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                cmd.Parameters.AddWithValue("@EMPID", empId);
                cmd.Parameters.AddWithValue("@ENAME", empRegisterNameTB.Text);
                cmd.Parameters.AddWithValue("@SALARY", empRegisterSalaryTB.Text);
                cmd.Parameters.AddWithValue("@PHONENUM", empRegisterMobileNumTB.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", empRegisterAddressTB.Text);
                cmd.Parameters.AddWithValue("@GENDER", gender);
                cmd.Parameters.AddWithValue("@ROLE", role);
                if (con.State == ConnectionState.Open)
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

            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }

            con = null;
            try
            {
                con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                con.Open();
                string query = $"insert into log_In (UserName, Password) values ('{ empId }','{empPasswordTB.Text}')";
                // SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

            this.Hide();
        }

        private void EmpRegistrtaionGoBackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
