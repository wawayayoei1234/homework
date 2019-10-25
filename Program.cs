using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)

        {



            IEnumerable<int> oop = null;
            string nums = null;// string.Empty;
            string myString = string.Empty;
            
            
            int myInt;


         
             
            int max = 4;
           
                Console.WriteLine("ป้อนค่่าตัวเลข 6 หลัก จำนวน 4 ค่า");
            for (int i = 0; i < max; i++)
            {
                  myString = Console.ReadLine();  //รับค่า

                  var array = myString.ToCharArray() .Where(x => int.TryParse
                            (x.ToString(), out myInt))
                            .Select(x => int.Parse
                            (x.ToString())).ToArray();  //แปลง string to array

                   var input = new run();        
                   oop = input.Homework13(array);
               
                   
                  foreach (var item in oop)
                 
                 nums+=item;
                  
                    
                 
                }
            Console.WriteLine("ค่าที่มีเลข 99 ต่อกัน 2 ตัว");
              Console.WriteLine(nums);
                

                       
                   
                  
                     
        }
    }
}
            
         
          
                
                     
                 

            
                 
                      
            
            
                   

                  
                       
                     
               
                       
            
        
                 
                   
           








