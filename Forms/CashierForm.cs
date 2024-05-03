using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cashierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cashierShowTrxBTN_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from TransactionDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            cashierDataGridView.DataSource = d1;
        }

        private void cashierLogotBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }
    }
}
