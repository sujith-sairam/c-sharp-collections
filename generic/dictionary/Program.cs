using System.Collections.Generic;

namespace Dictionary
{
    class MainClass{
        public static void Main(string[] args){
            //Declaring dictionary for contact book
            var contactBook = new Dictionary<string, string>();
            contactBook.Add("1234567890","Kiran");
            contactBook.Add("78900987651","Bob");
            contactBook.Add("345678900909","Alice");

            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Remove contact");
            Console.WriteLine("3. Show contact");
            Console.Write("Enter the option: ");
            
            //The switch case works with value given on the option
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    Console.Write("Enter the name: \n");
                    string name = Console.ReadLine();
                    Console.Write("Enter the mobile number: \n");
                    string mobile_number =  Console.ReadLine();
                    if(!contactBook.ContainsKey(mobile_number)){
                    contactBook.Add(mobile_number,name);
                    }else{
                        Console.WriteLine("Mobile Number is already present!!");
                    }
                    break;
                case 2:
                    Console.Write("Enter the number: ");
                    string number =  Convert.ToString(Console.ReadLine());
                    if(contactBook.ContainsKey(number)){
                        contactBook.Remove(number);
                        Console.WriteLine("Contact has been removed successfully");
                    }else{
                        Console.WriteLine("Contact not found!");
                    }
                    break;

                case 3:
                    foreach (var item in contactBook)
                    {
                        Console.WriteLine(item.Key +" " + item.Value);
                    }
                    break;

                default: 
                    Console.WriteLine("Enter a valid option:");
                    break;

        }
    }
}

}