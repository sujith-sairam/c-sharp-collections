// Store student name with cgpa with help of sorted list..
using System;
using System.Collections.Generic;

namespace SortedList{

    class MainClass{
        public static void Main( string[] args){
            //declaring sorted list 
            var studentCgpa= new SortedList<string, double>();
            studentCgpa.Add("Kiran",7.81);
            studentCgpa.Add("Bob",8.48);
            studentCgpa.Add("Alice",9.00);

            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Search contact");
            Console.WriteLine("3. Remove contact");
            Console.WriteLine("4. Show contact");
            Console.Write("Enter the option: ");

            //switch works with the given option value
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    Console.Write("Enter the name: \n");
                    string name = Console.ReadLine();
                    Console.Write("Enter the cgpa: \n");
                    double cgpa =  Convert.ToDouble(Console.ReadLine());
                    studentCgpa.Add(name,cgpa);
                    break;

                case 2:
                    Console.Write("Enter the name: ");
                    string Name = Console.ReadLine();
                    if(studentCgpa.ContainsKey(Name)){
                        Console.WriteLine(Name + " " + studentCgpa[Name] );
                    }else{
                        Console.WriteLine("Student not found!");
                    }
                    break;

                case 3:
                    Console.Write("Enter the name: ");
                    string removeName =  Convert.ToString(Console.ReadLine());
                    if(studentCgpa.ContainsKey(removeName)){
                        studentCgpa.Remove(removeName);
                        Console.WriteLine("Student has been removed successfully");
                    }else{
                        Console.WriteLine("Student not found!");
                    }
                    break;

                case 4:
                    foreach (var item in studentCgpa)
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