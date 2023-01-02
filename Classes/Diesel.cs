using System;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    class Diesel : Oil
    {
        protected static double dieselStock = 333333;
        public double perliterdieselcost = 108;
        private double dieselSell;

        public double PerliterDieselcost
        {
            get { return perliterdieselcost; }
            set { perliterdieselcost = value; }
        }

        public double setDieselStock
        {
            get { return dieselStock; }
            set { dieselStock = value; }
        }

        public Diesel()
        {
            //System.out.println("Empty-Diesel" + "\n" );
        }
        public Diesel(String tranNo, double sell, double DieselStock)
                     : base(tranNo, sell, stock)
        {
            dieselStock = DieselStock;
            this.totalCost = sell * this.perLiterCost;
            this.sell += sell;
            if (dieselStock > 0 && this.sell <= dieselStock)
            {
                dieselStock = dieselStock - this.sell;
            }
            else
            {
                MessageBox.Show("OUT OF STOCK!");
            }
        }


        public void DieselLift(double amount)
        {
            if (amount < (3333 - dieselStock))
            {
                dieselStock = dieselStock + amount;
                base.Stock += amount;
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        public double setDieselSell(double sell)
        {
            this.sell = sell;
            if (dieselStock > 0 && this.sell <= dieselStock)
            {
                dieselStock = dieselStock - sell;
                base.Stock -= sell;
                return sell;
            }
            else
            {
                MessageBox.Show("OUT OF STOCK!");
            }
            return sell;
        }

    }
}
