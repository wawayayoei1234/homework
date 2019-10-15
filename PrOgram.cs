using System;

namespace appppp {
    class Program {
        static void Main (string[] args) {
        
        //     int[] g ={0,0,0,0,0,0};
        //    string n = Convert.ToString(g);
            
            for (int i = 1; i <= 9; i++)
            
            {
                string b = string.Format("{0:000000}", i);
                try{
                    string result = string.Parse(b);
                    Console.WriteLine(result);

                }catch(FormatException)
                {
                    Console.WriteLine($"Unable to parse '{b}'");

                }
                
                
                
                if (b[4]+b[5]=="9") 
                {
                    
                     Console.WriteLine(b);
                }else
                {
                    Console.WriteLine("x");
                }
                
             }
             //Console.ReadLine();           
        }
     }
  }
