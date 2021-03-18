using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerID = 01;
            customer1.customerName = "Emre Şişman";
            customer1.email = "emre@gmail.com";
            customer1.phoneNumber=05545484;

            Customer customer2 = new Customer();
            customer2.customerID = 02;
            customer2.customerName = "Ali Yıldırım";
            customer2.email = "ali@gmail.com";
            customer2.phoneNumber = 05395545;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddNewCustomer(customer1);
            customerManager.DeleteCustomer(customer2);

            Customer[] customers = new Customer[] { customer1,customer2};

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.customerID+" "+customer.customerName+" "+customer.email+" "+customer.phoneNumber+" ");
                Console.WriteLine(" -------------------------------" );
            }

        }
    }
}
