using System;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    class Oil
    {

        protected String tranNo;
        protected double perLiterCost;
        protected double sell;
        protected double totalCost = 0.00;
        public static double stock = 999999;
        public Oil()
        {
            //System.out.println("Empty-Oil");
        }

        public Oil(String tranNo, double sell, double stock)
        {

            this.tranNo = tranNo;
            this.perLiterCost = perLiterCost;
            this.sell = sell;
            this.sell = sell;
            this.sell = sell;
            if (stock > 0 && this.sell <= stock)
            {
                stock = stock - this.sell;
            }
            else
            {
                MessageBox.Show("OUT OF STOCK!");
            }

        }
        public String TranNo
        {
            get { return tranNo; }
            set { tranNo = value; }
        }

        public double Totalcost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        public double Perlitercost
        {
            get { return perLiterCost; }
            set { perLiterCost = value; }
        }

        public double Sell
        {
            get { return sell; }
            set { sell = value; }
        }
        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public void lift(double amount)
        {
            if (amount < (999999 - stock))
            {
                stock = stock + amount;
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }
        public double Stocck(double amount)
        {

            amount = stock;
            return amount;

        }
        public double setSell(double sell)
        {
            this.sell = sell;
            if (stock > 0 && this.sell <= stock)
            {
                Stock = Stock - sell;
                return sell;
            }
            else
            {
                MessageBox.Show("OUT OF STOCK!");
            }
            return sell;
        }

        public void setTotalCost()
        {
            totalCost = sell * Perlitercost;
        }

        public double getTotalCost()
        {
            return totalCost;
        }
        public virtual void showDetails()
        {
            Console.WriteLine("TRAN NO : " + tranNo);
            Console.WriteLine("COST PER LITER : " + perLiterCost);
            Console.WriteLine("TOTAL AMOUNT TO BE PAID : " + getTotalCost() + " TAKA");
            Console.WriteLine("QUANTITY SOLD : " + sell + " LITER");
            Console.WriteLine("STOCK : " + stock);
            Console.WriteLine("-----------------------------------" + "\n");

        }
    }
}
