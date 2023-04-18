//Queue program to implement ticket counter..

using System.Collections;

namespace ThemePark{
    class TicketCounter{
        //Declaring queue for visitors
        private Queue visitors = new Queue();

        //Method for providing ticket to the users
        public void provideTicket(string name){
            visitors.Enqueue(name);
            Console.WriteLine("{0} has buyed the ticket",name);
        }

        //Method for allowing visitors to the users
        public void allowVisitor(){
            if(visitors.Count != 0){
            string visitor_name = (string)visitors.Dequeue();
            Console.WriteLine("{0} has visited the themepark",visitor_name);
            }else{
                Console.WriteLine("No visitors are remaining");
            }
        }
    }

    class MainClass{
        public static void Main(string[] args){

            TicketCounter counter = new TicketCounter();
            counter.provideTicket("sujith");
            counter.provideTicket("sam");
            counter.provideTicket("jack");
            counter.allowVisitor();
            counter.allowVisitor();
            counter.allowVisitor();
            counter.allowVisitor();
        }
    }
}