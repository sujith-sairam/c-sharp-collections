//Arraylist program to handle customer details..
using System.Collections;

namespace CustomerManagement{
 
    // Customer class with name and number fields
    class Customer{
        public string name{get;set;}
        public long phone_number{get;set;}

        public Customer(string name,long phone_number){
            this.name = name;
            this.phone_number = phone_number;
        }

    }
    class MainClass{
        public static void Main(string[] args){

            ArrayList customerList = new ArrayList();
            Customer customer1 = new Customer("Jack",1234567890);
            Customer customer2 = new Customer("Alice",9876543210);
            customerList.Add(customer1);
            customerList.Add(customer2);

            Console.WriteLine("1. Add new customer");
            Console.WriteLine("2. Show customer");
            Console.Write("Enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option){
                case 1:
                    string name = Console.ReadLine();
                    long phone_number = Convert.ToInt64(Console.ReadLine());
                    Customer customer = new Customer(name,phone_number);
                    customerList.Add(customer);
                    break;
                case 2:
                    foreach (Customer item in customerList)
                    {
                        Console.WriteLine(item.name + " " + item.phone_number);
                    }
                    break;
               }

        }
    }
}