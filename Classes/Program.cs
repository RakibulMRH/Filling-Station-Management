using FillingStationManagementSystem.Forms;
using System;
using System.Windows.Forms;

namespace FillingStationManagementSystem.Classes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingForm());



            //Octane oc1 = new Octane("1234", 135, 2, 0, 9500, "Octane");
            //// oc1.showDetails();
            //Diesel d1 = new Diesel("5678", 108, 3, 0, 9500, "Diesel");
            ////  d1.showDetails();
            //Petrol p1 = new Petrol("5678", 126, 5.5, 0, 7000, "Petrol");
            //// p1.showDetails();
            //Customer c1 = new Customer();
            //c1.insertOil(oc1);
            //c1.searchOil("1234");

            //FillingStation f1 = new FillingStation(100,100);
            //f1.insertCustomer(oc1);
        }
    }
}
