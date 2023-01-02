using System;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    class Octane : Oil
    {
        protected static double octaneStock;
        public double perliterOctanecost = 135;
        private double OctaneSell;


        public double PerliterOctanecost
        {
            get { return perliterOctanecost; }
            set { perliterOctanecost = value; }
        }

        public double setOctaneStock
        {
            get { return octaneStock; }
            set { octaneStock = value; }
        }

        public Octane()
        {
        }
        public Octane(String tranNo, double sell, double OctaneStock)
                     : base(tranNo, sell, stock)
        {
            octaneStock = OctaneStock;
            this.totalCost = sell * this.perLiterCost;
            this.sell += sell;
            if (octaneStock > 0 && this.sell <= octaneStock)
            {
                octaneStock = octaneStock - this.sell;
            }
            else
            {
                MessageBox.Show("OUT OF STOCK!");
            }
        }


        public void OctaneLift(double amount)
        {
            if (amount < (3333 - octaneStock))
            {
                octaneStock = octaneStock + amount;
                base.Stock += amount;
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        public double setOctaneSell(double sell)
        {
            this.sell = sell;
            if (octaneStock > 0 && this.sell <= octaneStock)
            {
                octaneStock = octaneStock - sell;
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
