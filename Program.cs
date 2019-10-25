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
                 {
                 nums+=item;
                 }  
                    
                 
                }
                var i1 = nums;
                var i2 = $"{i1[0]}{i1[1]}{i1[2]}{i1[3]}{i1[4]}{i1[5]}";
                var i3 = $"{i1[6]}{i1[7]}{i1[8]}{i1[9]}{i1[10]}{i1[11]}";
                var i4 = $"{i1[12]}{i1[13]}{i1[14]}{i1[15]}{i1[16]}{i1[17]}";
                var i5 = $"{i1[18]}{i1[19]}{i1[20]}{i1[21]}{i1[22]}{i1[23]}";
                Console.WriteLine("ค่าที่มีเลข 99 ต่อกัน 2 ตัว");
                Console.WriteLine($"{i2} {i3} {i4} {i5}");

                       
                   
                  
                     
        }
    }
}
            
         
          
                
                     
                 

            
                 
                      
            
            
                   

                  
                       
                     
               
                       
            
        
                 
                   
           








