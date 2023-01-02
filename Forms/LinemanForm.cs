using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Forms
{
    public partial class LinemanForm : Form
    {
        public LinemanForm()
        {
            InitializeComponent();
        }
        string empId, fuelId, liftDate, liftAmount;

        private void linemanOctaneidTB_TextChanged(object sender, EventArgs e)
        {
            fuelId = linemanOctaneidTB.Text;
        }

        private void linemanDieselTB_TextChanged(object sender, EventArgs e)
        {
            liftAmount = linemanDieselTB.Text;
        }

        private void linemanOctaneTB_TextChanged(object sender, EventArgs e)
        {
            liftAmount = linemanOctaneTB.Text;
        }

        private void linemanPetrolTB_TextChanged(object sender, EventArgs e)
        {
            liftAmount = linemanPetrolTB.Text;
        }

        private void linemanFormDateTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void linemanConfirmBTN_Click(object sender, EventArgs e)
        {
            //c.Insert(emp);
            bool isSuccess = false;
            //Login l1 = new Login();

            empId = linemanFormUserIdTB.Text;
            liftDate = linemanFormDateTB.Text;

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                con.Open();
                string query = $"insert into StockDB (EMPID,FUELID,LIFTDATE,LIFTAMOUNT) values ('{ empId }','{fuelId}','{liftAmount}','{linemanFormDateTB.Text}')";
                //  SqlDataAdapter sda = new SqlDataAdapter(query, con);
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

            //this.Hide();
            //LoginForm login = new LoginForm();
            //login.Show();
        }

        private void linemanLogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();

        }

        public String FuelId
        {
            get { return fuelId; }
            set { fuelId = value; }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection c1 = new SqlConnection("Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");

            DataTable d1 = new DataTable();

            //Step 2: Writing SQL query

            string query = "Select * from StockDB";

            //Creating cmd using sql and connection string            

            SqlDataAdapter sda = new SqlDataAdapter(query, c1);

            sda.Fill(d1);
            linemandataGridView.DataSource = d1;
        }

        private void linemanPetrolidTB_TextChanged(object sender, EventArgs e)
        {
            fuelId = linemanPetrolidTB.Text;
        }
    }
}
