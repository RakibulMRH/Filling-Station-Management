using System;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    class Petrol : Oil
    {
        protected static double petrolStock = 3333;
        public double petrolCost = 114;
        private double sell;

        public double PerliterPetrolcost
        {
            get { return PerliterPetrolcost; }
            set { PerliterPetrolcost = value; }
        }

        public double setPetrolStock
        {
            get { return petrolStock; }
            set { petrolStock = value; }
        }

        public Petrol()
        {
            //System.out.println("Empty-Diesel" + "\n" );
        }
        public Petrol(String tranNo, double sell, double PetrolStock)
                     : base(tranNo, sell, stock)
        {
            petrolStock = PetrolStock;
            this.totalCost = sell * this.perLiterCost;
            this.sell += sell;
            if (petrolStock > 0 && this.sell <= petrolStock)
            {
                petrolStock = petrolStock - this.sell;
            }
            else
            {
                MessageBox.Show("OUT OF STOCK!");
            }
        }


        public void Patrollift(double amount)
        {
            if (amount < (3333 - petrolStock))
            {
                petrolStock = petrolStock + amount;
                base.Stock += amount;
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        public double setPatrolSell(double sell)
        {
            this.sell = sell;
            if (petrolStock > 0 && this.sell <= petrolStock)
            {
                petrolStock = petrolStock - sell;
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
