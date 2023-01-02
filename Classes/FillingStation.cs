using System;

namespace FillingStationManagementSystem.Classes
{
    class FillingStation
    {
        protected Customer[] customers = new Customer[500];
        protected Employee[] employees = new Employee[100];

        public FillingStation(int size1, int size2)
        {
            Customer[] customers = new Customer[size1];
            Employee[] employees = new Employee[size2];
        }

        public bool insertCustomer(Customer c)
        {
            bool flag = false;
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] == null)
                {
                    customers[i] = c;
                    flag = true;
                    Console.WriteLine("INSERTED");

                    break;
                }
            }
            return flag;
        }

        public bool removeCustomer(Customer c)
        {
            bool flag = false;
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] == c)
                {
                    customers[i] = null;
                    flag = true;
                    Console.WriteLine("REMOVED");
                    break;
                }
            }
            return flag;
        }

        public Customer searchCustomer(String tranNo)
        {
            Customer c = null;

            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] != null)
                {
                    if (customers[i].TranNo.Equals(tranNo))
                    {
                        c = customers[i];
                        break;
                    }
                }
            }
            return c;
        }

        public void showAllCustomers()
        {
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] != null)
                {
                    Console.WriteLine("************************");
                    customers[i].showDetails();
                    //customers[i].showAllOils();
                    Console.WriteLine();
                }
            }
        }
        public bool insertEmployee(Employee e)
        {
            bool flag = false;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = e;
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public bool removeEmployee(Employee e)
        {
            bool flag = false;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == e)
                {
                    employees[i] = null;
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public Employee searchEmployee(String empId)
        {
            Employee e = null;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    if (employees[i].EmpId.Equals(empId))
                    {
                        e = employees[i];
                        break;
                    }
                }
            }
            return e;
        }
    }
}
