using FillingStationManagementSystem.Classes;
using FillingStationManagementSystem.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem
{
    public partial class RegisterForm : Form
    {
        Customer cs = new Customer();
        String Id, Name, phoneNum, address, gender;

        public RegisterForm()
        {
            InitializeComponent();
        }
        // SqlConnection con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationConfirmBTN_Click(object sender, EventArgs e)
        {
            if (registerNameTB.Text.Length > 0 && registerAddressTB.Text.Length > 0 && registerMobileNumTB.Text.Length > 0)
            {
                Id = cs.generateNewCusID();
                //c.Insert(emp);
                bool isSuccess = false;
                //Login l1 = new Login();

                Name = registerNameTB.Text;
                phoneNum = registerMobileNumTB.Text;
                address = registerAddressTB.Text;
                SqlConnection con = null;
                try
                {

                    con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                    con.Open();
                    string query = $"insert into CustomerDB (CUSID,NAME,PHONENUM,ADDRESS,GENDER) values ('{ Id }','{registerNameTB.Text}','{registerAddressTB.Text}','{registerMobileNumTB.Text}','{gender}')";
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
                con = null;
                try
                {

                    con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                    con.Open();
                    string query = $"insert into log_In (UserName, Password) values ('{ Id }','{registerPasswordTB.Text}')";
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
                LoginForm login = new LoginForm();
                login.Show();
            }
            else if (registerNameTB.Text.Length == 0 || registerAddressTB.Text.Length == 0 || registerMobileNumTB.Text.Length == 0)
            {
                MessageBox.Show("You Must fill All the forms First!!");
            }

        }

        private void registerNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerAddressTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrtaionLoginGuestBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Guest g = new Guest();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();

        }

        private void registerMobileNumTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationMaleRB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void registrationFemaleRB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void registrationOthersRB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Others";
        }
    }
}
