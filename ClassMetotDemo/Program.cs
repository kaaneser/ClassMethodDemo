using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdded = false;
            int choice;
            Customer customer = new Customer();
            Customer[] customers = new Customer[10];
            CustomerManager customerManager = new CustomerManager();

            while(true)
            {
                Console.WriteLine("1. Add Customers\n2. List Customers\n3. Delete Customer\n4. Exit");
                Console.WriteLine("Please select something:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        if (isAdded == true)
                        {
                            Console.WriteLine("You already added the customers.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("How many customers do you want to add?: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (num >= 10)
                            {
                                Console.WriteLine("You can't add " + num + " customers. (max. 10)");
                                break;
                            }
                            for (int i = 0; i < num; i++)
                            {
                                customerManager.addCustomer(customers, i);
                            }
                            Console.WriteLine("Customers added successfully.");
                            isAdded = true;
                            break;
                        }
                    case 2:
                        customerManager.listCustomer(customers);
                        break;
                    case 3:
                        Console.WriteLine("Enter the ID of the customer: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        customerManager.deleteCustomer(customers, id);
                        break;
                    case 4:
                        Console.WriteLine("Exitting from the program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You entered wrong number. Please enter existing choice number.");
                        break;
                }
            }
            
        }
    }
}
