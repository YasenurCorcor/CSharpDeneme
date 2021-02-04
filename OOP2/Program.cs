using System;

namespace OOP2
{
    class Program
    {
        //OOP is missing in sector, so this is important
        // everybody know syntax of OOP
        //SOLID-- L
        static void Main(string[] args)
        {
            //Yasenur Corcor
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.Id = 1;
            customer1.CustomerName = "Yasenur";
            customer1.CustomerSurname = "Corcor";
            customer1.TcNumber = "12345678910";

            //corcor.com
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "corcor.com";
            customer2.TaxNumber = "1234567890";

            Console.WriteLine(customer1.CustomerNumber);
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.CustomerName);
            Console.WriteLine(customer1.CustomerSurname);
            Console.WriteLine(customer1.TcNumber);

            Console.WriteLine("-----");

            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.CustomerNumber);
            Console.WriteLine(customer2.CompanyName);
            Console.WriteLine(customer2.TaxNumber);




            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            // if you see "new" is a referance number
            // Customer include IndivialCustomer and CorporateCustomer
            //"new" include IndivialCustomer's reference number and CorporateCustomer's reference number

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
