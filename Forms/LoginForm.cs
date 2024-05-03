using FillingStationManagementSystem.Classes;
using FillingStationManagementSystem.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace FillingStationManagementSystem
{
    public partial class LoginForm : Form
    {
        OracleConnection connection;
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
        string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=gaslogix;PASSWORD=tiger";
       

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
                OracleConnection connection = new OracleConnection(connectionString);
                // Open the database connection
                connection.Open();

                String query = "SELECT * FROM login WHERE username='username_here' AND password='password_here'";
                OracleCommand command = new OracleCommand(query, connection);

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable d1 = new DataTable();
                adapter.Fill(d1);

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
