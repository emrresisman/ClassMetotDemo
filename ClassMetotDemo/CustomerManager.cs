using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddNewCustomer(Customer customer)
        {
            Console.WriteLine("Customer succesfully added : "+customer.customerName);
        }
        public void DeleteCustomer(Customer customer)
        {
            customer.customerID = 0;
            customer.customerName = "";
            customer.email = "";
            customer.phoneNumber = 0;


            Console.WriteLine("Customer succesfully deleted : " + customer.customerName);
        }
        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("Customer details here : "+" ID: "+ customer.customerID +" Name: "+customer.customerName+" Mail: "+customer.email+" Phone Number: "+customer.phoneNumber);
        }
    }
}
