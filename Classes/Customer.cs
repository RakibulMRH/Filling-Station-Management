using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    class Customer
    {
        private String cusID = "CA-";
        private String LcusID = "-22";
        private String tranNo = "TR9X1NO";
        private String name;
        private String address;
        private String phoneNum;
        private String gender;
        protected Oil[] oils = new Oil[200];

        public Customer()
        {
            Console.WriteLine("E-Customer");
        }
        public Customer(Oil o)
        {
            Console.WriteLine("P-Customer");
        }

        public String TranNo
        {
            get { return tranNo; }
            set { tranNo = value; }
        }
        public String generateNewTranNO()
        {
            int baseID = 100001;
            int rows = 0;

            SqlConnection c1 = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {
                String querry = "SELECT * FROM TransactionDB";
                SqlDataAdapter sda = new SqlDataAdapter(querry, c1);
                DataTable d1 = new DataTable();
                sda.Fill(d1);
                rows = d1.Rows.Count;
                baseID += rows;
                tranNo += baseID;
                //MessageBox.Show(tranNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong!");
            }
            finally
            {
                c1.Close();
            }

            return tranNo;
        }

        public String generateNewCusID()
        {
            int baseID = 10001;
            int rows = 0;

            SqlConnection c1 = new SqlConnection(@"Data Source=desktop-thvjfsm;Initial Catalog=FillingStationManagement;Integrated Security=True");
            try
            {
                String querry = "SELECT * FROM CustomerDB";
                SqlDataAdapter sda = new SqlDataAdapter(querry, c1);
                DataTable d1 = new DataTable();
                sda.Fill(d1);
                rows = d1.Rows.Count;
                baseID += rows;
                LcusID = baseID + LcusID;
                cusID += LcusID;
                MessageBox.Show("Your User ID: " + cusID);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong!");

            }
            finally
            {
                c1.Close();
            }

            return cusID;
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String PhoneNo
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public bool insertOil(Oil o)
        {
            bool flag = false;

            for (int i = 0; i < oils.Length; i++)
            {
                if (oils[i] == null)
                {
                    oils[i] = o;
                    flag = true;
                    Console.WriteLine("INSERTED");
                    break;
                }
            }
            return flag;

        }

        public bool removeOil(Oil o)
        {
            bool flag = false;
            for (int i = 0; i < oils.Length; i++)
            {
                if (oils[i] == o)
                {
                    oils[i] = null;
                    flag = true;
                    Console.WriteLine("\n****OIL****\n");
                    Console.WriteLine("*UPDATE* :The  OIL of TRANSNO:" + o.TranNo + "has been removed successfully.\n");
                    return flag;
                }
            }
            return flag;
        }

        public Oil searchOil(String tranNo)
        {
            Oil o = null;

            for (int i = 0; i < oils.Length; i++)
            {
                if (oils[i] != null)
                {
                    if (oils[i].TranNo == tranNo)
                    {
                        Console.WriteLine("*SEARCH COMPLETED*");
                        Console.WriteLine("*SEARCHED TRAN-NO NO: " + tranNo + " FOUND*");
                        o = oils[i];
                        Console.WriteLine("##############################");
                        o.showDetails();
                        Console.WriteLine("##############################");
                        return oils[i];
                    }
                }
            }
            Console.WriteLine("*SEARCH COMPLETED*");
            Console.WriteLine("*SEARCHED Tran-NO NO: " + tranNo + " NOT FOUND*");
            return null;
        }

        public void showAllOils()
        {
            for (int i = 0; i < oils.Length; i++)
            {
                if (oils[i] != null)
                {
                    oils[i].showDetails();
                }
            }
        }

        public void showDetails()
        {

            this.showAllOils();
            Console.WriteLine();
        }
    }
}
