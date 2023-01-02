using FillingStationManagementSystem.Classes;
using FillingStationManagementSystem.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem
{
    public partial class LoginForm : Form
    {
        public static String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection c1 = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

        private void logInFormExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.UserName = logInUserNameTB.Text;
            l1.Password = loginPasswordTB.Text;

            try
            {
                String querry = "SELECT * FROM Log_In Where UserName='" + logInUserNameTB.Text + "' AND Password='" + loginPasswordTB.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, c1);
                DataTable d1 = new DataTable();
                sda.Fill(d1);

                if (d1.Rows.Count > 0 && (l1.UserName.Substring(0, 2) == "ad" || l1.UserName.Substring(0, 2) == "Ad" || l1.UserName.Substring(0, 2) == "AD"))
                {
                    CEOForm E1 = new CEOForm();
                    this.Hide();
                    E1.Show();
                }

                else if (d1.Rows.Count > 0 && (l1.UserName.Substring(0, 2) == "MG"))
                {
                    ManagerForm M1 = new ManagerForm();
                    this.Hide();
                    M1.Show();
                }

                else if (d1.Rows.Count > 0 && (l1.UserName.Substring(0, 2) == "AC"))
                {
                    CashierForm C1 = new CashierForm();
                    this.Hide();
                    C1.Show();
                }

                else if (d1.Rows.Count > 0 && (l1.UserName.Substring(0, 2) == "LM"))
                {
                    LinemanForm L1 = new LinemanForm();
                    this.Hide();
                    L1.Show();
                }
                else if (d1.Rows.Count > 0 && (l1.UserName.Substring(0, 2) == "CA"))
                {
                    username = logInUserNameTB.Text;
                    CustomerForm C2 = new CustomerForm();
                    this.Hide();
                    C2.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Credentials!!!\nTry again.");

                }

            }
            catch
            {
                MessageBox.Show("WRONG CREDITALS!!\n TRY AGAIN.");
            }
            finally
            {
                c1.Close();
            }

        }

        private void loginRegisterBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm rg = new RegisterForm();
            rg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1500, WinAPI.BLEND);
        }
    }
}
