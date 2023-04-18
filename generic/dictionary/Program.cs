using System.Collections.Generic;

namespace Dictionary
{
    

    class MainClass{
        public static void Main(string[] args){
            var contactBook = new Dictionary<string, string>();
            contactBook.Add("Kiran","1234567890");
            contactBook.Add("Bob","78900987651");
            contactBook.Add("Alice","345678900909");

            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Search contact");
            Console.WriteLine("3. Remove contact");
            Console.WriteLine("4. Show contact");
            Console.Write("Enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option){
                case 1:
                    Console.Write("Enter the name: \n");
                    string name = Console.ReadLine();
                    Console.Write("Enter the mobile number: \n");
                    string mobile_number =  Console.ReadLine();
                    if(!contactBook.ContainsKey(name)){
                    contactBook.Add(name,mobile_number);
                    }else{
                        Console.WriteLine("Contact Name is already present!!");
                    }
                    break;

                case 2:
                    Console.Write("Enter the name: ");
                    string Name = Convert.ToString(Console.ReadLine());
                    if(contactBook.ContainsKey(Name)){
                        Console.WriteLine(Name + " " + contactBook[Name] );
                    }else{
                        Console.WriteLine("Contact not found!");
                    }
                    break;

                case 3:
                    Console.Write("Enter the name: ");
                    string removeName =  Convert.ToString(Console.ReadLine());
                    if(contactBook.ContainsKey(removeName)){
                        contactBook.Remove(removeName);
                        Console.WriteLine("Contact has been removed successfully");
                    }else{
                        Console.WriteLine("Contact not found!");
                    }
                    break;

                case 4:
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