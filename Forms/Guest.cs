using FillingStationManagementSystem.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Forms
{
    public partial class Guest : Form
    {

        Customer cs = new Customer();
        Oil oil = new Oil();
        Petrol pet = new Petrol();
        Octane oct = new Octane();
        Diesel dis = new Diesel();
        double amount, discount, partial, total, stockvalue;
        String SelectedOil, amt, amd, date = "21-12-22", TID;

        public Guest()
        {

            InitializeComponent();
            TID = cs.generateNewTranNO();
            gcustomerTrxTB.Text = TID;
        }

        private void gcustomerTrxTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gcustomerPetrolRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOil = "Petrol";
        }

        private void gcustomerOctaneRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOil = "Octane";
        }

        private void gcustomerDieselRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOil = "Diesel";
        }

        private void gcustomerLogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm Ln = new LoginForm();
            Ln.Show();
        }

        private void Guest_Load(object sender, EventArgs e)
        {

        }

        private void gcustomerAmountTB_TextChanged(object sender, EventArgs e)
        {

        }


        private void customerAmountBTN_Click(object sender, EventArgs e)
        {
            amt = gcustomerAmountTB.Text;

            double.TryParse(amt, out amount);

            if (SelectedOil == "Petrol")
            {
                pet.setPatrolSell(amount);
                total = amount * 114;
                gcutomerTotalTB.Text = total.ToString();
            }
            if (SelectedOil == "Octane")
            {
                oct.setOctaneSell(amount);
                total = amount * 135;
                gcutomerTotalTB.Text = total.ToString();
            }
            if (SelectedOil == "Diesel")
            {
                dis.setDieselSell(amount);
                total = amount * 108;
                gcutomerTotalTB.Text = total.ToString();
            }
            amd = gcutomerTotalTB.Text;
            double.TryParse(amt, out partial);

            SqlConnection con = null;
            try
            {

                con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                con.Open();
                string query = $"insert into TransactionDB (TRANNO, TRXDATE,AMOUNT) values ('{ gcustomerTrxTB.Text }','{date}','{Convert.ToInt32(amount)}')";
                // SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                TID = cs.generateNewTranNO();
                gcustomerTrxTB.Text = TID;

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
