using FillingStationManagementSystem.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Forms
{
    public partial class CustomerForm : Form
    {
        Customer cs = new Customer();
        Oil oil = new Oil();
        Petrol pet = new Petrol();
        Octane oct = new Octane();
        Diesel dis = new Diesel();
        double amount, discount, partial, total, stockvalue;

        String SelectedOil, amt, amd, date = "21-12-22";


        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void customerAmountTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerAmountBTN_Click(object sender, EventArgs e)
        {
            amt = customerAmountTB.Text;

            double.TryParse(amt, out amount);

            if (SelectedOil == "Petrol")
            {
                pet.setPatrolSell(amount);
                total = amount * 114;
                cutomerTotalTB.Text = total.ToString();
            }
            if (SelectedOil == "Octane")
            {
                oct.setOctaneSell(amount);
                total = amount * 135;
                cutomerTotalTB.Text = total.ToString();
            }
            if (SelectedOil == "Diesel")
            {
                dis.setDieselSell(amount);
                total = amount * 108;
                cutomerTotalTB.Text = total.ToString();
            }
            amd = cutomerTotalTB.Text;
            double.TryParse(amt, out partial);

            if (amount > 100.00)
            {

                Button Rewards = new Button();
                this.Controls.Add(Rewards);

                Rewards.BackColor = System.Drawing.Color.Chocolate;
                Rewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Rewards.ForeColor = System.Drawing.Color.White;
                Rewards.Location = new System.Drawing.Point(337, 137);
                Rewards.Name = "customerRewardsTB";
                Rewards.Size = new System.Drawing.Size(164, 33);
                Rewards.TabIndex = 16;
                Rewards.Text = "Rewards";
                Rewards.UseVisualStyleBackColor = false;

                discount = (amount - 100) * 0.02 + 2;
                partial = partial - (discount / 100);
                total -= partial;
                label6.Show();
                customerDiscoutTotalTB.Show();
                Rewards.Text = "-" + partial.ToString() + " BDT";
                customerDiscoutTotalTB.Text = total.ToString();

            }

            SqlConnection con = null;
            try
            {

                con = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
                con.Open();
                string query = $"insert into TransactionDB (TRANNO, TRXDATE,AMOUNT,CUSID,DISCOUNT) values ('{ customerTrxTB.Text }','{date}','{Convert.ToInt32(amount)}','{customerIDTB.Text}','{discount.ToString()}')";
                // SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }

        private void customerPetrolRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOil = "Petrol";
        }

        private void customerOctaneRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOil = "Octane";
        }

        private void customerDieselRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOil = "Diesel";
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void customerTrxTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void customerDiscoutTotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerLogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm Ln = new LoginForm();
            Ln.Show();
        }

        private void customerIDTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            oil.Stocck(stockvalue);

            LoginForm l = new LoginForm();
            customerIDTB.Text = l.Username;
            customerTrxTB.Text = cs.generateNewTranNO();
            label6.Hide();
            customerDiscoutTotalTB.Hide();
        }

        private void cutomerTotalTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
