using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem
{
    public partial class ManagerForm : Form
    {
        string trxId;
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void managerLogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm Ln = new LoginForm();
            Ln.Show();
        }

        private void managerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void managerShowEmpBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from EmployeeDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            managerDataGridView.DataSource = d1;
        }

        private void ceoShowTrxBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from TransactionDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            managerDataGridView.DataSource = d1;
        }

        private void managerShowStocksBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from StockDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            managerDataGridView.DataSource = d1;

        }

        private void managerRemoveTrxBTN_Click(object sender, EventArgs e)
        {

            //Login l1 = new Login();


            trxId = managerTrxIdTB.Text;

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                con.Open();
                string query = $"delete from TransactionDB  where TRANNO='{trxId}'";

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
