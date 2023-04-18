// display  integer list separately from an arraylist which contains both string and integer..

using System.Collections.Generic;
using System.Collections;

namespace List{

    class MainClass{
        public static void Main( string[] args){

            //ArrayList with collection of strings and numbers
            ArrayList data = new ArrayList(){
                2,"Bill","Sam",87,1,"Noise",456,"Pot","Eighty",201,56,"jack",45
            };
            //Declaring integer list
            List<int> integerList = new List<int>();

            int data_count = data.Count;
            for(int i=0;i<data_count;i++){
                 if(data[i].GetType().Equals(typeof(Int32))){
                    integerList.Add(Convert.ToInt32(data[i]));
                }
            }

            Console.WriteLine("The elements in the integer list:");
            foreach (var item in integerList)
            {
                Console.Write(" " + item);
            }
            
        }
    }
}