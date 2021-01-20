using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void addCustomer(Customer[] customers, int i)
        {
            Customer customer = new Customer();
            Console.WriteLine("Please enter the " + (i+1) + ". customer's name: ");
            customer.name = Console.ReadLine();
            Console.WriteLine("Please enter the " + (i+1) + ". customer's surname: ");
            customer.surname = Console.ReadLine();
            Console.WriteLine("Please enter the " + (i+1) + ". customer's inital cash: ");
            customer.cash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the " + (i+1) + ". customer's id: ");
            customer.customerID = Convert.ToInt32(Console.ReadLine());
            customers[i] = customer;
            
            Console.WriteLine("New customer added successfully.\n");
        }

        public void listCustomer(Customer[] customers)
        {
            Console.WriteLine("Customer List: \n");
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] == null)
                    break;
                Console.WriteLine("------- CUSTOMER " + (i+1) + " -------");
                Console.WriteLine("Customer ID: " + customers[i].customerID);
                Console.WriteLine("Name: " + customers[i].name);
                Console.WriteLine("Surname: " + customers[i].surname);
                Console.WriteLine("Customer's Cash: " + customers[i].cash);
                Console.WriteLine("-------------------------");
            }
        }
        
        public void deleteCustomer(Customer[] customers, int id)
        {
            Console.WriteLine("Customer is searching from the customer list...\n");
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] == null)
                    break;
                if (id == customers[i].customerID)
                {
                    Console.WriteLine("Customer found, deleting..");
                    for (int j = i; j < customers.Length-1; j++)
                    {
                        customers[j] = customers[j + 1];
                    }
                }
            }
            Console.WriteLine("Customer deleted succesfully.\n");
        }
    }
}
