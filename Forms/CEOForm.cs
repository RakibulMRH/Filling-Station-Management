using FillingStationManagementSystem.Classes;
using FillingStationManagementSystem.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem
{
    public partial class CEOForm : Form
    {
        EmpRegister E1 = new EmpRegister();
        string empId, fuelId, liftDate, liftAmount, tranNo;
        SqlConnection con = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
        public CEOForm()
        {
            InitializeComponent();
        }

        private void ceoEnterEmployeeBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            E1.Show();
        }

        private void ceoLogoutBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
            LoginForm Ln = new LoginForm();
            Ln.Show();
        }

        private void ceoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ceoEmpShowBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from EmployeeDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            ceoDataGridView.DataSource = d1;
        }

        private void ceoShowTrxBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from CustomerDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            ceoDataGridView.DataSource = d1;
        }

        private void ceoShowStocksBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from StockDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            ceoDataGridView.DataSource = d1;
        }

        private void CEOForm_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.HOR_Positive);
            label3.Text = DateTime.Now.ToString();
        }

        private void ceoRemoveEmpBTN_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            //Login l1 = new Login();
            empId = ceoEmpIdTB.Text;


            try
            {
                string query = "DELETE FROM EmployeeDB WHERE empId=@EMPID";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                cmd.Parameters.AddWithValue("@EMPID", ceoEmpIdTB.Text);


                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                        MessageBox.Show("Succesfully Removed!");
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
        }

        private void ceoShowTransactionBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from TransactionDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            ceoDataGridView.DataSource = d1;
        }

        private void ceoLiftdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label3.Text = DateTime.Now.ToString();
        }

        private void ceoRemoveTrxBTN_Click(object sender, EventArgs e)
        {
            //c.Insert(emp);
            bool isSuccess = false;
            //Login l1 = new Login();


            tranNo = ceoTrxIdTB.Text;

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                con.Open();
                string query = $"delete from TransactionDB  where TRANNO='{tranNo}'";

                //  SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REMOVED!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
            LinemanForm l1 = new LinemanForm();
            l1.Show();
        }

        private void ceoRemoveStockBTN_Click(object sender, EventArgs e)
        {
            //c.Insert(emp);
            bool isSuccess = false;
            //Login l1 = new Login();


            fuelId = ceoLiftdTB.Text;

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                con.Open();
                string query = $"delete from StockDB where FUELID ='{fuelId}'";

                //  SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REMOVED!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
