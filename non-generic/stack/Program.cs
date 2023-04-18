using System.Collections;

namespace Network{

    //Declaring a class for browser..
    class Browser{

        //creating stack for handling browsing histories..
        private Stack history = new Stack();

        //navigate method that display the current url and added to stack
        public void navigate(string url){
            Console.WriteLine("Navigating to {0}",url);
            history.Push(url);
        }

        //back method to visit the previous url by poping the current url
        public void back(){
            if(history.Count == 0){
                Console.WriteLine("Browser cannot navigate backward..");
                return;
            }else{
                history.Pop();
                if(history.Count!=0){
                    string top_url = (string)history.Peek();
                    Console.WriteLine("Going back to {0}",top_url);
                }
            }
        }
    }

    class MainClass{

        public static void Main(string[] args){

            Browser browser = new Browser();
            browser.navigate("www.google.com");
            browser.navigate("www.twitter.com");
            browser.navigate("www.flipkart.com");
            browser.back();
            browser.back();
            browser.back();
            browser.back();

        }
    }
}